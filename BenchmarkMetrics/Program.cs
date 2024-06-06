using BenchmarkDotNet.Running;
using BenchmarkMetrics;
using System;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<StringCompare>();
