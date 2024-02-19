using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;

namespace LazyIterationTest
{
    public class CustomConfig : ManualConfig
    {
        public CustomConfig()
        {
            AddJob(Job.Default
                .WithIterationCount(3)
                .WithWarmupCount(1));

            AddDiagnoser(MemoryDiagnoser.Default);
            AddLogger(ConsoleLogger.Default);
            AddColumnProvider(DefaultColumnProviders.Instance);
        }
    }
}