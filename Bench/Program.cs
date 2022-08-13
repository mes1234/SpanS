// See https://aka.ms/new-console-template for more information
using Bench;
using BenchmarkDotNet.Running;


var summary = BenchmarkRunner.Run<StringMagicBench>();
