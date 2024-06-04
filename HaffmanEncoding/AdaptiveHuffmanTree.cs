using System.Text;

namespace HaffmanEncoding
{
    class AdaptiveHuffmanTree
    {
        public AdaptiveHuffmanNode Root { get; private set; } = null!;

        private AdaptiveHuffmanNode _nyt = null!;
        private AdaptiveHuffmanNode[] _nodes = null!;
        private int _nextNum;

        public AdaptiveHuffmanTree()
        {
            Reset();
        }

        public void Reset()
        {
            Root = new AdaptiveHuffmanNode { Number = 512 };
            _nyt = Root;
            _nodes = new AdaptiveHuffmanNode[513];
            _nodes[Root.Number] = Root;
            _nextNum = 511;
        }

        public string Encode(string text)
        {
            var result = new StringBuilder();

            foreach (var c in text)
            {
                result.Append(Encode(c));
            }

            return result.ToString();
        }

        public string Encode(char symbol)
        {
            AdaptiveHuffmanNode? node = Root.FindOrDefault(symbol);

            string? code;

            if (node != null)
            {
                code = Root.GetCode(node);
                node.Weight++;
            }
            else
            {
                code = Root.GetNYTCode(string.Empty);
                code += symbol;
                node = AddToNYT(symbol);
            }

            UpdateAll(node.Parent);

            return code;
        }

        public string Decode(string code)
        {
            var result = new StringBuilder();

            int index = 0;
            while (index < code.Length)
            {
                AdaptiveHuffmanNode? node;

                char? symbol = ReadChar(index, code, out int count);
                index += count;

                if (symbol == null)
                {
                    symbol = code[index - 1];
                    node = AddToNYT(symbol.Value);
                }
                else
                {
                    node = Root.FindOrDefault(symbol.Value);
                    node!.Weight++;
                }

                UpdateAll(node.Parent);

                result.Append(symbol.Value);
            }

            return result.ToString();
        }

        private char? ReadChar(int index, string code, out int count)
        {
            AdaptiveHuffmanNode current = Root;
            count = 0;

            while (true)
            {
                count++;

                if (current == _nyt)
                {
                    return null;
                }

                if (current.IsLeaf())
                {
                    count--;
                    return current.Symbol;
                }

                char bit = code[index++];

                if (bit == '0')
                {
                    current = current.Left;
                }  else if (bit == '1')
                {
                    current = current.Right;
                }
            }
        }

        private AdaptiveHuffmanNode AddToNYT(char symbol)
        {
            var node = new AdaptiveHuffmanNode(_nyt, symbol)
            {
                Number = _nextNum
            };

            _nyt.Right = node;
            _nodes[_nextNum--] = node;
            var nyt = new AdaptiveHuffmanNode(_nyt) {
                Number = _nextNum,
                IsNYT = true
            };

            _nyt.IsNYT = false;
            _nyt.Left = nyt;
            _nodes[_nextNum--] = nyt;
            _nyt = nyt;
            return node;
        }

        private void UpdateAll(AdaptiveHuffmanNode node)
        {
            while (node != null)
            {
                Update(node);
                node = node.Parent;
            }
        }

        private void Update(AdaptiveHuffmanNode node)
        {
            AdaptiveHuffmanNode? toReplace = NodeToReplace(node.Number, node.Weight);

            if (toReplace != null && node.Parent != toReplace)
            {
                Replace(node, toReplace);
            }

            node.Weight++;
        }

        private AdaptiveHuffmanNode? NodeToReplace(int startIndex, int weight)
        {
            startIndex++;
            AdaptiveHuffmanNode? found = null;

            for (int i = startIndex; i < _nodes.Length; i++)
            {
                if (_nodes[i].Weight == weight)
                {
                    found = _nodes[i];
                }
            }

            return found;
        }

        private void Replace(AdaptiveHuffmanNode a, AdaptiveHuffmanNode b)
        {
            ReplaceNumbers(a, b);
            ReplaceSons(a, b);
        }

        private void ReplaceNumbers(AdaptiveHuffmanNode a, AdaptiveHuffmanNode b)
        {
            AdaptiveHuffmanNode temp = _nodes[a.Number];
            _nodes[a.Number] = _nodes[b.Number];
            _nodes[b.Number] = temp;

            int tempNum = a.Number;
            a.Number = b.Number;
            b.Number = tempNum;
        }

        private void ReplaceSons(AdaptiveHuffmanNode a, AdaptiveHuffmanNode b)
        {
            bool bIsLeftSon = b.Parent.IsLeftSon(b);

            if (a.Parent.IsLeftSon(a))
            {
                a.Parent.Left = b;
            } else
            {
                a.Parent.Right = b;
            }

            AdaptiveHuffmanNode temp = b.Parent;
            b.Parent = a.Parent;
            a.Parent = temp;

            if (bIsLeftSon)
            {
                temp.Left = a;
            } else
            {
                temp.Right = a;
            }
        }
    }
}
