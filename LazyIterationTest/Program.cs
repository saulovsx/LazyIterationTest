using BenchmarkDotNet.Running;
using Microsoft.Extensions.Configuration;

namespace LazyIterationTest
{
    class Program
    {
        public static IConfiguration? config;
        static void Main()
        {
            BenchmarkRunner.Run<FileProcess>(new CustomConfig());            
        }
    }
}