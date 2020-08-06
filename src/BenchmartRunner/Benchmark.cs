using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Flurl.Http;
using Grpc.Core;
using LegacyLib;
using LegacyLib.Dto;
using LegacyLib.Service;
using ProtoBuf.Grpc.Client;

namespace BenchmartRunner
{
    [SimpleJob(RuntimeMoniker.Net461, baseline: true)]
    [RPlotExporter]
    public class Benchmark
    {
        private int callCounter = 100;
        private IService service = null;

        [GlobalSetup]
        public void Setup()
        {
            var instance = FakeDataProvider.Instance.GetRequest();
            service = new SomeLegacyService();
        }


        [Benchmark]
        public void TestLocalServerCalls()
        {
            int UPPER = callCounter;
            for (int i = 0; i < UPPER; i++)
            {
                var requestDto = FakeDataProvider.Instance.GetRequest();

                var someResult = service.CalculateSomething(requestDto);

            }

        }

        [Benchmark]
        public void TestGprcServerCalls()
        {
            int UPPER = callCounter;

            var channel = new Channel("localhost", 10055, ChannelCredentials.Insecure);
            try
            {

                
                var remoteService = channel.CreateGrpcService<IService>();
                for (int i = 0; i < UPPER; i++)
                {
                    var requestDto = FakeDataProvider.Instance.GetRequest();
                    
                    var result = remoteService.CalculateSomething(requestDto);

                    
                }
            }
            catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            finally
            {
                channel.ShutdownAsync();
            }
            
        }

        [Benchmark]
        public void TestWebApiServerCalls()
        {
            int UPPER = callCounter;

            string uri = "http://localhost:28550/api/Some";
            for (int i = 0; i < UPPER; i++)
            {
                var requestDto = FakeDataProvider.Instance.GetRequest();

                var someResult = uri.WithHeaders(new { Accept = "application/json", }).PostJsonAsync(requestDto).ReceiveJson<Result>().GetAwaiter().GetResult();

            }

        }

    }
}
