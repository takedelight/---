using System;
using System.Collections.Generic;
using System.Text;

namespace ср.data_structures
{
    public class HuffmanCodec
    {
        private class Node
        {
            public char Ch { get; set; }
            public int Freq { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(char c, int f) { Ch = c; Freq = f; }
            public Node(char c, int f, Node l, Node r)
            {
                Ch = c; Freq = f; Left = l; Right = r;
            }
        }

        private string inputData;
        private Dictionary<char, string> codes = new Dictionary<char, string>();
        private Node root;
        private string encodedData;

        public int OriginalSize { get; private set; } 
        public int CompressedSize { get; private set; }

        public bool SetInputFile(string filename)
        {
            if (!File.Exists(filename)) return false;
            inputData = File.ReadAllText(filename);
            OriginalSize = inputData.Length * 8;
            return true;
        }

        public void Compress()
        {
            if (string.IsNullOrEmpty(inputData)) return;

            var freq = new Dictionary<char, int>();
            foreach (char c in inputData)
            {
                if (freq.ContainsKey(c)) freq[c]++;
                else freq[c] = 1;
            }


            var pq = new PriorityQueue<Node, int>();
            foreach (var p in freq)
            {
                pq.Enqueue(new Node(p.Key, p.Value), p.Value);
            }

            while (pq.Count > 1)
            {
                var a = pq.Dequeue();
                var b = pq.Dequeue();
                var merged = new Node('\0', a.Freq + b.Freq, a, b);
                pq.Enqueue(merged, merged.Freq);
            }

            root = pq.Dequeue();

            codes.Clear();
            BuildCodes(root, "");

            StringBuilder sb = new StringBuilder();
            foreach (char c in inputData)
            {
                sb.Append(codes[c]);
            }
            encodedData = sb.ToString();
            CompressedSize = encodedData.Length;
        }

        private void BuildCodes(Node node, string prefix)
        {
            if (node == null) return;
            if (node.Left == null && node.Right == null)
            {
                codes[node.Ch] = prefix;
                return;
            }
            BuildCodes(node.Left, prefix + "0");
            BuildCodes(node.Right, prefix + "1");
        }

        public string Decompress()
        {
            if (root == null || string.IsNullOrEmpty(encodedData)) return "";

            StringBuilder decoded = new StringBuilder();
            Node current = root;

            foreach (char bit in encodedData)
            {
                current = (bit == '0') ? current.Left : current.Right;

                if (current.Left == null && current.Right == null)
                {
                    decoded.Append(current.Ch);
                    current = root;
                }
            }
            return decoded.ToString();
        }

        public void SaveCompressed(string filename) => File.WriteAllText(filename, encodedData);

        public Dictionary<char, string> GetCodes() => codes;
    }
}
