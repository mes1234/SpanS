namespace SpanS
{
    public static class MagicMaker
    {
        public static string StringNormalMagic(string input)
        {
            return input.ToUpper();
        }


        public static ReadOnlySpan<char> StringSpanMagic(ReadOnlySpan<char> input)
        {
            var output = new Span<char>(input.ToArray());

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = char.ToUpper(input[i]);
            }

            return output;
        }
    }
}