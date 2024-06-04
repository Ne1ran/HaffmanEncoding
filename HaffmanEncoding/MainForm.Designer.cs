namespace HaffmanEncoding
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outputFilePathTextBox = new TextBox();
            inputFilePathTextBox = new TextBox();
            decodeHuffman2Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            encodeHuffman2Btn = new Button();
            label3 = new Label();
            label4 = new Label();
            encodeHuffman1Btn = new Button();
            decodeHuffman1Btn = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // outputFilePathTextBox
            // 
            outputFilePathTextBox.Location = new Point(450, 71);
            outputFilePathTextBox.Name = "outputFilePathTextBox";
            outputFilePathTextBox.Size = new Size(286, 23);
            outputFilePathTextBox.TabIndex = 0;
            // 
            // inputFilePathTextBox
            // 
            inputFilePathTextBox.Location = new Point(48, 71);
            inputFilePathTextBox.Name = "inputFilePathTextBox";
            inputFilePathTextBox.Size = new Size(286, 23);
            inputFilePathTextBox.TabIndex = 1;
            // 
            // decodeHuffman2Btn
            // 
            decodeHuffman2Btn.Location = new Point(529, 303);
            decodeHuffman2Btn.Name = "decodeHuffman2Btn";
            decodeHuffman2Btn.Size = new Size(120, 54);
            decodeHuffman2Btn.TabIndex = 3;
            decodeHuffman2Btn.Text = "Декодировать";
            decodeHuffman2Btn.UseVisualStyleBackColor = true;
            decodeHuffman2Btn.Click += DecodeHuffman2Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(48, 37);
            label1.Name = "label1";
            label1.Size = new Size(237, 19);
            label1.TabIndex = 4;
            label1.Text = "Введите путь к файлу для работы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(450, 37);
            label2.Name = "label2";
            label2.Size = new Size(275, 19);
            label2.TabIndex = 5;
            label2.Text = "Введите путь для записи нового файла:";
            // 
            // encodeHuffman2Btn
            // 
            encodeHuffman2Btn.Location = new Point(529, 203);
            encodeHuffman2Btn.Name = "encodeHuffman2Btn";
            encodeHuffman2Btn.Size = new Size(120, 54);
            encodeHuffman2Btn.TabIndex = 7;
            encodeHuffman2Btn.Text = "Закодировать";
            encodeHuffman2Btn.UseVisualStyleBackColor = true;
            encodeHuffman2Btn.Click += EncodeHuffman2Btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(29, 159);
            label3.Name = "label3";
            label3.Size = new Size(334, 21);
            label3.TabIndex = 8;
            label3.Text = "Однопроходное кодирование Хаффмана";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(429, 159);
            label4.Name = "label4";
            label4.Size = new Size(329, 21);
            label4.TabIndex = 9;
            label4.Text = "Двухпроходное кодирование Хаффмана";
            // 
            // encodeHuffman1Btn
            // 
            encodeHuffman1Btn.Location = new Point(125, 203);
            encodeHuffman1Btn.Name = "encodeHuffman1Btn";
            encodeHuffman1Btn.Size = new Size(120, 54);
            encodeHuffman1Btn.TabIndex = 11;
            encodeHuffman1Btn.Text = "Закодировать";
            encodeHuffman1Btn.UseVisualStyleBackColor = true;
            encodeHuffman1Btn.Click += EncodeHuffman1Btn_Click;
            // 
            // decodeHuffman1Btn
            // 
            decodeHuffman1Btn.Location = new Point(125, 303);
            decodeHuffman1Btn.Name = "decodeHuffman1Btn";
            decodeHuffman1Btn.Size = new Size(120, 54);
            decodeHuffman1Btn.TabIndex = 10;
            decodeHuffman1Btn.Text = "Декодировать";
            decodeHuffman1Btn.UseVisualStyleBackColor = true;
            decodeHuffman1Btn.Click += DecodeHuffman1Btn_Click;
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultLabel.ForeColor = Color.Red;
            resultLabel.Location = new Point(12, 116);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(776, 21);
            resultLabel.TabIndex = 12;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(encodeHuffman1Btn);
            Controls.Add(decodeHuffman1Btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(encodeHuffman2Btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(decodeHuffman2Btn);
            Controls.Add(inputFilePathTextBox);
            Controls.Add(outputFilePathTextBox);
            Name = "MainForm";
            Text = "HuffmanEncoding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputFilePathTextBox;
        private TextBox inputFilePathTextBox;
        private Button decodeHuffman2Btn;
        private Label label1;
        private Label label2;
        private Button encodeHuffman2Btn;
        private Label label3;
        private Label label4;
        private Button encodeHuffman1Btn;
        private Button decodeHuffman1Btn;
        private Label resultLabel;
    }
}
