// See https://aka.ms/new-console-template for more information
using Calculator;
using client;
using Dummy;
using Greet;
using Grpc.Core;

//Server url
const string target = "localhost:5001";

Channel channel = new Channel(target,ChannelCredentials.Insecure);
await channel.ConnectAsync().ContinueWith((t) => { 
    if(t.Status == TaskStatus.RanToCompletion)
        Console.WriteLine("The client connected successfully!");
});

#region Greeting Service Call
DemoClass demoClass = new DemoClass();
demoClass.UnaryCallExample(channel);
await demoClass.ServerStreamingExample(channel);
await demoClass.ClientStreamingExample(channel);
await demoClass.BiDirectionalStreamingExample(channel);
await demoClass.DeadlineCallExample(channel);
#endregion

#region Assignments
AssignmentClass.AdditionServiceUnary(channel);
await AssignmentClass.PrimeNumberDecompositionServerStreaming(channel);
await AssignmentClass.CalculateAverageClientStreaming(channel);
await AssignmentClass.FindMaximumNumberBiDirectionalStreaming(channel);
AssignmentClass.ErrorHandlingExample(channel);
#endregion


channel.ShutdownAsync().Wait();
Console.ReadKey();
