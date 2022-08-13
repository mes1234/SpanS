namespace SpanS
{
    public static class MagicMaker
    {
        public static string StringNormalMagic(string input)
        {
            return string.Empty;
        }


        public static ReadOnlySpan<char> StringSpanMagic(ReadOnlySpan<char> input)
        {
            return new ReadOnlySpan<char>(input.ToArray());
        }
    }
}