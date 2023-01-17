// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Calculator {
  public static partial class CalculateService
  {
    static readonly string __ServiceName = "calculator.CalculateService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.AdditionRequest> __Marshaller_calculator_AdditionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.AdditionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.AdditionResponse> __Marshaller_calculator_AdditionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.AdditionResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.PrimeNumberDecoRequest> __Marshaller_calculator_PrimeNumberDecoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.PrimeNumberDecoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.PrimeNumberDecoResponse> __Marshaller_calculator_PrimeNumberDecoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.PrimeNumberDecoResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeAvgRequest> __Marshaller_calculator_ComputeAvgRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeAvgRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeAvgResponse> __Marshaller_calculator_ComputeAvgResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeAvgResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.FindMaxRequest> __Marshaller_calculator_FindMaxRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.FindMaxRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.FindMaxResponse> __Marshaller_calculator_FindMaxResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.FindMaxResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.AdditionRequest, global::Calculator.AdditionResponse> __Method_Addition = new grpc::Method<global::Calculator.AdditionRequest, global::Calculator.AdditionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Addition",
        __Marshaller_calculator_AdditionRequest,
        __Marshaller_calculator_AdditionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.PrimeNumberDecoRequest, global::Calculator.PrimeNumberDecoResponse> __Method_PrimeNumberDecomposition = new grpc::Method<global::Calculator.PrimeNumberDecoRequest, global::Calculator.PrimeNumberDecoResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "PrimeNumberDecomposition",
        __Marshaller_calculator_PrimeNumberDecoRequest,
        __Marshaller_calculator_PrimeNumberDecoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.ComputeAvgRequest, global::Calculator.ComputeAvgResponse> __Method_CalculateAverage = new grpc::Method<global::Calculator.ComputeAvgRequest, global::Calculator.ComputeAvgResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "CalculateAverage",
        __Marshaller_calculator_ComputeAvgRequest,
        __Marshaller_calculator_ComputeAvgResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.FindMaxRequest, global::Calculator.FindMaxResponse> __Method_FindMaximumNumber = new grpc::Method<global::Calculator.FindMaxRequest, global::Calculator.FindMaxResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "FindMaximumNumber",
        __Marshaller_calculator_FindMaxRequest,
        __Marshaller_calculator_FindMaxResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Calculator.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalculateService</summary>
    [grpc::BindServiceMethod(typeof(CalculateService), "BindService")]
    public abstract partial class CalculateServiceBase
    {
      /// <summary>
      /// Unary Call
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculator.AdditionResponse> Addition(global::Calculator.AdditionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task PrimeNumberDecomposition(global::Calculator.PrimeNumberDecoRequest request, grpc::IServerStreamWriter<global::Calculator.PrimeNumberDecoResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculator.ComputeAvgResponse> CalculateAverage(grpc::IAsyncStreamReader<global::Calculator.ComputeAvgRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Bi-directional Streaming
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task FindMaximumNumber(grpc::IAsyncStreamReader<global::Calculator.FindMaxRequest> requestStream, grpc::IServerStreamWriter<global::Calculator.FindMaxResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CalculateService</summary>
    public partial class CalculateServiceClient : grpc::ClientBase<CalculateServiceClient>
    {
      /// <summary>Creates a new client for CalculateService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculateServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CalculateService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculateServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculateServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculateServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Unary Call
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculator.AdditionResponse Addition(global::Calculator.AdditionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Addition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Unary Call
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculator.AdditionResponse Addition(global::Calculator.AdditionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Addition, null, options, request);
      }
      /// <summary>
      /// Unary Call
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculator.AdditionResponse> AdditionAsync(global::Calculator.AdditionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AdditionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Unary Call
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculator.AdditionResponse> AdditionAsync(global::Calculator.AdditionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Addition, null, options, request);
      }
      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Calculator.PrimeNumberDecoResponse> PrimeNumberDecomposition(global::Calculator.PrimeNumberDecoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrimeNumberDecomposition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Calculator.PrimeNumberDecoResponse> PrimeNumberDecomposition(global::Calculator.PrimeNumberDecoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_PrimeNumberDecomposition, null, options, request);
      }
      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Calculator.ComputeAvgRequest, global::Calculator.ComputeAvgResponse> CalculateAverage(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CalculateAverage(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Calculator.ComputeAvgRequest, global::Calculator.ComputeAvgResponse> CalculateAverage(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_CalculateAverage, null, options);
      }
      /// <summary>
      /// Bi-directional Streaming
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Calculator.FindMaxRequest, global::Calculator.FindMaxResponse> FindMaximumNumber(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindMaximumNumber(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bi-directional Streaming
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Calculator.FindMaxRequest, global::Calculator.FindMaxResponse> FindMaximumNumber(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_FindMaximumNumber, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CalculateServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculateServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CalculateServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Addition, serviceImpl.Addition)
          .AddMethod(__Method_PrimeNumberDecomposition, serviceImpl.PrimeNumberDecomposition)
          .AddMethod(__Method_CalculateAverage, serviceImpl.CalculateAverage)
          .AddMethod(__Method_FindMaximumNumber, serviceImpl.FindMaximumNumber).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculateServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Addition, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculator.AdditionRequest, global::Calculator.AdditionResponse>(serviceImpl.Addition));
      serviceBinder.AddMethod(__Method_PrimeNumberDecomposition, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Calculator.PrimeNumberDecoRequest, global::Calculator.PrimeNumberDecoResponse>(serviceImpl.PrimeNumberDecomposition));
      serviceBinder.AddMethod(__Method_CalculateAverage, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Calculator.ComputeAvgRequest, global::Calculator.ComputeAvgResponse>(serviceImpl.CalculateAverage));
      serviceBinder.AddMethod(__Method_FindMaximumNumber, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Calculator.FindMaxRequest, global::Calculator.FindMaxResponse>(serviceImpl.FindMaximumNumber));
    }

  }
}
#endregion
