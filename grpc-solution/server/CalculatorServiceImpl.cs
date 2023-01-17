using Calculator;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.CalculateService;

namespace server
{
    public class CalculatorServiceImpl : CalculateServiceBase
    {
        public override Task<AdditionResponse> Addition(AdditionRequest request, ServerCallContext context)
        {
            int result = request.IntInputValue.A + request.IntInputValue.B;
            return Task.FromResult(new AdditionResponse() { Result = result });
        }

        public override async Task PrimeNumberDecomposition(PrimeNumberDecoRequest request, IServerStreamWriter<PrimeNumberDecoResponse> responseStream, ServerCallContext context)
        {
            Console.WriteLine("The server received the request:");
            Console.WriteLine(request.ToString());
            int diviser = 2;
            int primeNum = request.PrimeNumInput.PrimeNumber;
            while (primeNum > 1)
            {
                if (primeNum % diviser == 0)
                {
                    await responseStream.WriteAsync(new PrimeNumberDecoResponse() { Result = diviser });
                    primeNum = primeNum / diviser;
                }
                else
                {
                    diviser++;
                }
            }
        }
        public override async Task<ComputeAvgResponse> CalculateAverage(IAsyncStreamReader<ComputeAvgRequest> requestStream, ServerCallContext context)
        {
            double cal_avg = 0;
            int counter = 0;
            while(await requestStream.MoveNext())
            {
                counter++;
                cal_avg += requestStream.Current.ComputeAvgInput.NumToAverage;
            }
            return await Task.FromResult(new ComputeAvgResponse() { CalAvg = cal_avg / counter});
        }
        public override async Task FindMaximumNumber(IAsyncStreamReader<FindMaxRequest> requestStream, IServerStreamWriter<FindMaxResponse> responseStream, ServerCallContext context)
        {

            int? max = null;
            while (await requestStream.MoveNext())
            {
                if (max == null || max < requestStream.Current.FindMaxInput.NumToMax)
                {
                    max = requestStream.Current.FindMaxInput.NumToMax;
                    await responseStream.WriteAsync(new FindMaxResponse() { MaxNumber = max.Value });
                }
            }

        }
    }
}
