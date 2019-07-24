using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace AffectsOfAsyncKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Tests>();

        }
        public class Tests
        {
            [Benchmark]
            public void NormalMethodTest()
            {
                NormalMethod();
            }
            [Benchmark]
            public void NormalMethodAsyncTest()
            {
                NormalMethodAsync();
            }

            public void NormalMethod()
            {
            }
            public async void NormalMethodAsync()
            {
            }

        }
    }
}