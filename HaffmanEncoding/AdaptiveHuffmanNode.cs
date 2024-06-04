namespace HaffmanEncoding
{
    class AdaptiveHuffmanNode
    {
        public char? Symbol { get; set; }
        public int Weight { get; set; }
        public int Number { get; set; }
        public AdaptiveHuffmanNode? Left { get; set; }
        public AdaptiveHuffmanNode? Right { get; set; }
        public AdaptiveHuffmanNode? Parent { get; set; }
        public bool IsNYT { get; set; }

        public AdaptiveHuffmanNode() { }

        public AdaptiveHuffmanNode(AdaptiveHuffmanNode parent)
        {
            Parent = parent;
        }

        public AdaptiveHuffmanNode(AdaptiveHuffmanNode parent, char symbol)
        {
            Parent = parent;
            Symbol = symbol;
            Weight = 1;
        }

        public AdaptiveHuffmanNode? FindOrDefault(char symbol)
        {
            if (Symbol == symbol)
            {
                return this;
            }

            AdaptiveHuffmanNode? result = Left?.FindOrDefault(symbol);
            if (result != null)
            {
                return result;
            }

            return Right?.FindOrDefault(symbol);
        }

        public string? GetCode(AdaptiveHuffmanNode searched)
        {
            return GetCode(searched, String.Empty);
        }

        private string? GetCode(AdaptiveHuffmanNode searched, string code)
        {
            if (Symbol == searched.Symbol)
            {
                return code;
            }

            if (Left == null && Right == null)
            {
                return null;
            }

            string? result = Left?.GetCode(searched, code + "0");
            if (result != null)
            {
                return result;
            }

            return Right?.GetCode(searched, code + "1");
        }

        public string? GetNYTCode(string code)
        {
            if (IsNYT)
            {
                return code;
            }

            if (Left == null && Right == null)
            {
                return null;
            }

            string? result = Left?.GetNYTCode(code + "0");
            if (result != null)
            {
                return result;
            }

            return Right?.GetNYTCode(code + "1");
        }

        public bool IsLeftSon(AdaptiveHuffmanNode son)
        {
            return Left == son;
        }

        public bool IsRightSon(AdaptiveHuffmanNode son)
        {
            return Right == son;
        }

        public bool IsLeaf()
        {
            return Left == null && Right == null;
        }
    }
}
