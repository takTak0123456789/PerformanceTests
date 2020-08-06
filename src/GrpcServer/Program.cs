using System;
using Grpc.Core;
using LegacyLib.Service;
using ProtoBuf.Grpc.Server;

namespace GrpcServer
{
    class Program
    {
        ////https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted
        //// https://github.com/cyanfish/grpc-dotnet-namedpipes
        public static void Main(string[] args)
        {
            try
            {
                const int Port = 10055;
                Server server = new Server
                {
                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
                };
                server.Services.AddCodeFirst(new SomeLegacyService());
                server.Start();

                Console.WriteLine("server listening on port " + Port);
                Console.ReadKey();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }
}
