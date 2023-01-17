using Calculator;
using Grpc.Core;
using Sqrt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    public static class AssignmentClass
    {
        public static void AdditionServiceUnary(Channel channel)
        {
            var clientCalc = new CalculateService.CalculateServiceClient(channel);
            var inputValue = new IntInputValue()
            {
                A = 5,
                B = 7
            };
            var addRequest = new AdditionRequest() { IntInputValue = inputValue };
            var addResponse = clientCalc.Addition(addRequest);
            Console.WriteLine("Calculator Service Addition Output (Unary): " + addResponse.Result);

        }
        public static async Task PrimeNumberDecompositionServerStreaming(Channel channel)
        {
            var clientCalc = new CalculateService.CalculateServiceClient(channel);

            // Server Streaming
            var primeNum = new PrimeNumInput()
            {
                PrimeNumber = 120
            };
            var primeNumRequest = new PrimeNumberDecoRequest() { PrimeNumInput = primeNum };
            var primeNumResponse = clientCalc.PrimeNumberDecomposition(primeNumRequest);
            Console.WriteLine("Calculator Service Server Streaming call");
            while (await primeNumResponse.ResponseStream.MoveNext())
            {
                Console.WriteLine(primeNumResponse.ResponseStream.Current.Result);
                await Task.Delay(200);
            }

        }
        public static async Task CalculateAverageClientStreaming(Channel channel)
        {
            var clientCalc = new CalculateService.CalculateServiceClient(channel);
            var calcAvgStream = clientCalc.CalculateAverage();
            int input = 1;
            foreach (int i in Enumerable.Range(1, 4))
            {
                await calcAvgStream.RequestStream.WriteAsync(new ComputeAvgRequest() { ComputeAvgInput = new ComputeAvgInput() { NumToAverage = input } });
                input++;
            }
            await calcAvgStream.RequestStream.CompleteAsync();
            var calcAvgResponse = calcAvgStream.ResponseAsync.Result;
            Console.WriteLine("Calculator Service Calculate Average in Client Streaming: " + calcAvgResponse);
        }
        public static async Task FindMaximumNumberBiDirectionalStreaming(Channel channel)
        {
            var clientCalc = new CalculateService.CalculateServiceClient(channel);
            var findMaxStream = clientCalc.FindMaximumNumber();
            var findMaxResponseTask = Task.Run(async () =>
            {
                while (await findMaxStream.ResponseStream.MoveNext())
                {
                    Console.WriteLine("Received: " + findMaxStream.ResponseStream.Current.MaxNumber);
                }
            });
            FindMaxInput[] findMaxInputs =
            {
                new FindMaxInput(){ NumToMax = 1},
                new FindMaxInput(){ NumToMax = 5},
                new FindMaxInput(){ NumToMax = 3},
                new FindMaxInput(){ NumToMax = 6},
                new FindMaxInput(){ NumToMax = 2},
                new FindMaxInput(){ NumToMax = 20}
            };

            foreach (FindMaxInput findMax in findMaxInputs)
            {
                await findMaxStream.RequestStream.WriteAsync(new FindMaxRequest()
                {
                    FindMaxInput = new FindMaxInput()
                    {
                        NumToMax = findMax.NumToMax
                    }
                });
            }
            await findMaxStream.RequestStream.CompleteAsync();
            await findMaxResponseTask;
        }

        public static async Task ErrorHandlingExample(Channel channel)
        {
            var client = new SqrtService.SqrtServiceClient(channel);
            try
            {
                var sqrtResponse = client.sqrt(new SqrtMessage() { Number = -1 });
                Console.WriteLine("Sqrt Response: {0}", sqrtResponse.SqrtRoot);
            }
            catch(RpcException ex)
            {
                Console.WriteLine("Error Details: "+ ex.Status.Detail);
            }
        }
    }
}
