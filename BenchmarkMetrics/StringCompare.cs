using BenchmarkDotNet.Attributes;
using System;

namespace BenchmarkMetrics
{
    public class StringCompare
    {
        public string firstName = "Maria";
        public string secondNome = "mARiA";

        [Benchmark]
        public bool CompareWithToLower()
        {
            return firstName.ToLower() == secondNome.ToLower();
        }

        [Benchmark]
        public bool CompareWithToUpper()
        {
            return firstName.ToUpper() == secondNome.ToUpper();
        }

        [Benchmark]
        public bool CompareWithEqualsIgnoreCase()
        {
            return firstName.Equals(secondNome, StringComparison.OrdinalIgnoreCase);
        }
    }
}
