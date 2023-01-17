using Greet;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    public class DemoClass
    {
        
        public void UnaryCallExample(Channel channel)
        {
            var client = new GreetingService.GreetingServiceClient(channel);

            var greeting = new Greeting()
            {
                FirstName = "Anil",
                LastName = "Yadav"
            };

            // Unary Call
            var requestGreeting = new GreetingRequest() { Greeting = greeting };
            var responseGreeting = client.Greet(requestGreeting);
            Console.WriteLine("Greeting Service Output (Unary): " + responseGreeting.Result);

        }
        public async Task ServerStreamingExample(Channel channel)
        {
            var client = new GreetingService.GreetingServiceClient(channel);
            var greeting = new Greeting()
            {
                FirstName = "Anil",
                LastName = "Yadav"
            };
            // Server Streaming Call
            var requestManyTimesGreeting = new GreetManyTimesRequest() { Greeting = greeting };
            var responseManyTimesGreeting = client.GreetManyTimes(requestManyTimesGreeting);
            Console.WriteLine("Greeting Service Output (Server Streaming): ");
            while (await responseManyTimesGreeting.ResponseStream.MoveNext())
            {
                Console.WriteLine(responseManyTimesGreeting.ResponseStream.Current.Result);
                await Task.Delay(200);
            }
        }
        public async Task ClientStreamingExample(Channel channel)
        {
            var client = new GreetingService.GreetingServiceClient(channel);
            // Client Streaming
            var longGreetReq = new LongGreetRequest() { Greeting = new Greeting() { FirstName = "Anil 1", LastName = "Yadav" } };
            var stream = client.LongGreet();
            foreach (int i in Enumerable.Range(1, 10))
            {
                await stream.RequestStream.WriteAsync(longGreetReq);
            }
            await stream.RequestStream.CompleteAsync();
            var clientStreamResponse = stream.ResponseAsync.Result;
            Console.WriteLine("The Client Streaming Call result : " + clientStreamResponse);

        }
        public async Task BiDirectionalStreamingExample(Channel channel)
        {
            var client = new GreetingService.GreetingServiceClient(channel);
            var greetEveryoneStream = client.GreetEveryone();
            var responseReaderTask = Task.Run(async () =>
            {
                while (await greetEveryoneStream.ResponseStream.MoveNext())
                {
                    Console.WriteLine("Received: " + greetEveryoneStream.ResponseStream.Current.Result);
                }

            });

            Greeting[] greetings =
            {
                new Greeting(){ FirstName="anil1" , LastName="yadav1" },
                new Greeting(){ FirstName="anil2" , LastName="yadav2" },
                new Greeting(){ FirstName="anil3" , LastName="yadav3" }
            };
            foreach (Greeting greetingMessage in greetings)
            {
                await greetEveryoneStream.RequestStream.WriteAsync(new GreetEveryoneRequest() { Greeting = greetingMessage });
            }
            await greetEveryoneStream.RequestStream.CompleteAsync();
            await responseReaderTask;
        }

        public async Task DeadlineCallExample(Channel channel)
        {
            var client = new GreetingService.GreetingServiceClient(channel);
            try
            {
                var response = await client.GreetWithDeadlineAsync(new GreetDeadlineRequest() { Name = "Anil Yadav" },deadline: DateTime.UtcNow.AddMilliseconds(400));
                Console.WriteLine("Deadline Call Output: "+ response);
            }
            catch(RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
            {
                Console.WriteLine("Exception occurred due to deadline exceed! "+ ex.Status.Detail);
            }
        }
    }
}
