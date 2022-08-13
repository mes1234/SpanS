using BenchmarkDotNet.Attributes;
using SpanS;
namespace Bench
{
    [MemoryDiagnoser]
    public class StringMagicBench
    {
        [Benchmark]
        public void BenchClassic()
        {
            var result = MagicMaker.StringNormalMagic("dummy");
        }

        [Benchmark]
        public void BenchSpan()
        {
            var result = MagicMaker.StringSpanMagic("dummy".AsSpan());
        }
    }
}
