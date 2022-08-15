using BenchmarkDotNet.Attributes;
using SpanS;
namespace Bench
{
    [MemoryDiagnoser]
    [HtmlExporter]
    public class StringMagicBench
    {
        [Params(10, 1000, 10000)]
        public int Loops { get; set; }

        private string _data = string.Empty;


        [GlobalSetup]
        public async Task GlobalSetup()
        {
            _data = await MeteoClient.GetMeteo();

            var logger = new BenchmarkDotNet.Loggers.ConsoleLogger();

            logger.WriteLine(BenchmarkDotNet.Loggers.LogKind.Default, $"Recieved data from remote API with lenght : {_data.Length} characters");

            if (_data == string.Empty)
                throw new NotSupportedException("Empty respone");
        }


        [Benchmark]
        public void BenchClassic()
        {
            foreach (var _ in Enumerable.Range(0, Loops))
                MagicMaker.StringNormalMagic(_data);
        }

        [Benchmark]
        public void BenchSpan()
        {
            foreach (var _ in Enumerable.Range(0, Loops))
                MagicMaker.StringSpanMagic(_data.AsSpan());
        }
    }
}
