using System.Collections;

namespace HaffmanEncoding
{
    public partial class MainForm : Form
    {
        private string _inputFilePath = null!;
        private string _outputFilePath = null!;
        private HuffmanTree _baseHuffmanTree = null!;
        private AdaptiveHuffmanTree _adaptiveHuffmanTree = null!;

        public MainForm()
        {
            InitializeComponent();
        }

        private void EncodeHuffman2Btn_Click(object sender, EventArgs e)
        {
            if (!TryReadFilePaths())
            {
                return;
            }

            try
            {
                var fileText = File.ReadAllText(_inputFilePath);
                _baseHuffmanTree = new HuffmanTree();
                _baseHuffmanTree.Build(fileText);
                byte[] encoded = _baseHuffmanTree.Encode(fileText);
                File.WriteAllBytes(_outputFilePath, encoded);
                resultLabel.Text = $"�������� ������������� �����������! ������� ���� � �����: {DateTime.Now}";
            }
            catch (Exception)
            {
                resultLabel.Text = "�������� ������ ��� ������������� �����������!";
            }
        }

        private void DecodeHuffman2Btn_Click(object sender, EventArgs e)
        {
            if (!TryReadFilePaths())
            {
                return;
            }

            try
            {
                byte[] encodedData = File.ReadAllBytes(_inputFilePath);
                var encodedBitArray = new BitArray(encodedData);
                string decoded = _baseHuffmanTree.Decode(encodedBitArray);
                File.WriteAllText(_outputFilePath, decoded);
                resultLabel.Text = $"�������� ������������� �������������! ������� ���� � �����: {DateTime.Now}";
            }
            catch (Exception)
            {
                resultLabel.Text = "�������� ������ ��� ������������� �������������!";
            }
        }

        private void EncodeHuffman1Btn_Click(object sender, EventArgs e)
        {
            if (!TryReadFilePaths())
            {
                return;
            }

            try
            {
                var fileText = File.ReadAllText(_inputFilePath);
                _adaptiveHuffmanTree = new AdaptiveHuffmanTree();
                var encoded = _adaptiveHuffmanTree.Encode(fileText);
                File.WriteAllText(_outputFilePath, encoded);
                resultLabel.Text = $"�������� ������������� �����������! ������� ���� � �����: {DateTime.Now}";
            }
            catch (Exception)
            {
                resultLabel.Text = "�������� ������ ��� ������������� �����������!";
            }
        }

        private void DecodeHuffman1Btn_Click(object sender, EventArgs e)
        {
            if (!TryReadFilePaths())
            {
                return;
            }

            try
            {
                var encodedText = File.ReadAllText(_inputFilePath);
                _adaptiveHuffmanTree = new AdaptiveHuffmanTree();
                string decoded = _adaptiveHuffmanTree.Decode(encodedText);
                File.WriteAllText(_outputFilePath, decoded);
                resultLabel.Text = $"�������� ������������� �������������! ������� ���� � �����: {DateTime.Now}";
            }
            catch (Exception)
            {
                resultLabel.Text = "�������� ������ ��� ������������� �������������!";
            }
        }

        private bool TryReadFilePaths()
        {
            string currentInputFilePath = inputFilePathTextBox.Text.Trim();
            string currentOutputFilePath = outputFilePathTextBox.Text.Trim();
            if (string.IsNullOrEmpty(currentInputFilePath) )
            {
                resultLabel.Text = "���� � ��������� ����� ����!";
                return false;
            }

            if (string.IsNullOrEmpty(currentOutputFilePath) )
            {
                resultLabel.Text = "���� � ����� ��� ������ ����!";
                return false;
            }

            _inputFilePath = inputFilePathTextBox.Text;
            if (!File.Exists(_inputFilePath) )
            {
                resultLabel.Text = "�������� ���� �� ����������!";
                return false;
            }

            _outputFilePath = outputFilePathTextBox.Text;
            return true;
        }
    }
}
