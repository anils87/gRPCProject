// See https://aka.ms/new-console-template for more information
using Calculator;
using Greet;
using Grpc.Core;
using server;
using Sqrt;
using System.Net;

Console.WriteLine("Hello, World!");
const int Port = 5001;

Server server = null;
try
{
    server = new Server()
    {
        // register the services
        Services = {
            GreetingService.BindService(new GreetingServiceImpl()),
            CalculateService.BindService(new CalculatorServiceImpl()),
            SqrtService.BindService(new SqrtServiceImpl()),
        },
        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
    };
    server.Start();
    Console.WriteLine("The server is listening on port : "+Port);

    Console.ReadKey();
}
catch(IOException ex)
{
    Console.WriteLine("The server failed to start : "+ ex.Message);
    throw;
}
finally
{
    if(server != null)
        server.ShutdownAsync().Wait();    
}