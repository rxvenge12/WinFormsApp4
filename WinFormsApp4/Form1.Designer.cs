namespace WinFormsApp4
{
    partial class Form1
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
            richTextBox1 = new RichTextBox();
            btnMultiply = new Button();
            btnCheckNegatives = new Button();
            btnArraySize = new Button();
            btnCompare = new Button();
            btnSum = new Button();
            btnDifference = new Button();
            btnCount = new Button();
            btnCheckChar = new Button();
            textBoxTestString = new TextBox();
            label1 = new Label();
            textBoxTestChar = new TextBox();
            label2 = new Label();
            btnRemoveNegatives = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(651, 200);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(12, 239);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(212, 63);
            btnMultiply.TabIndex = 1;
            btnMultiply.Text = "кнопка для выполнения операции умножения массивов.";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click_1;
            // 
            // btnCheckNegatives
            // 
            btnCheckNegatives.Location = new Point(230, 239);
            btnCheckNegatives.Name = "btnCheckNegatives";
            btnCheckNegatives.Size = new Size(182, 63);
            btnCheckNegatives.TabIndex = 2;
            btnCheckNegatives.Text = "содержит ли массив отрицательные элементы.";
            btnCheckNegatives.UseVisualStyleBackColor = true;
            btnCheckNegatives.Click += btnCheckNegatives_Click_1;
            // 
            // btnArraySize
            // 
            btnArraySize.Location = new Point(418, 239);
            btnArraySize.Name = "btnArraySize";
            btnArraySize.Size = new Size(186, 63);
            btnArraySize.TabIndex = 3;
            btnArraySize.Text = "получение размера массива";
            btnArraySize.UseVisualStyleBackColor = true;
            btnArraySize.Click += btnArraySize_Click_1;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(12, 308);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(212, 72);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "проверка равенства двух массивов и сравнения их размеров.";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click_1;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(230, 308);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(182, 72);
            btnSum.TabIndex = 5;
            btnSum.Text = "вычисление суммы элементов массива.";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click_1;
            // 
            // btnDifference
            // 
            btnDifference.Location = new Point(418, 308);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new Size(186, 72);
            btnDifference.TabIndex = 6;
            btnDifference.Text = "вычисление разницы между максимальным и минимальным элементами массива.";
            btnDifference.UseVisualStyleBackColor = true;
            btnDifference.Click += btnDifference_Click_1;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(12, 386);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(212, 63);
            btnCount.TabIndex = 7;
            btnCount.Text = "подсчет количества элементов в массиве.";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click_1;
            // 
            // btnCheckChar
            // 
            btnCheckChar.Location = new Point(230, 386);
            btnCheckChar.Name = "btnCheckChar";
            btnCheckChar.Size = new Size(182, 63);
            btnCheckChar.TabIndex = 8;
            btnCheckChar.Text = "выполнение проверки наличия определенного символа в строке.";
            btnCheckChar.UseVisualStyleBackColor = true;
            btnCheckChar.Click += btnCheckChar_Click_1;
            // 
            // textBoxTestString
            // 
            textBoxTestString.Location = new Point(883, 615);
            textBoxTestString.Name = "textBoxTestString";
            textBoxTestString.Size = new Size(204, 23);
            textBoxTestString.TabIndex = 9;
            textBoxTestString.TextChanged += textBoxTestString_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 618);
            label1.Name = "label1";
            label1.Size = new Size(356, 15);
            label1.TabIndex = 10;
            label1.Text = "ввод строки для проверки на наличие определенного символа";
            // 
            // textBoxTestChar
            // 
            textBoxTestChar.Location = new Point(883, 560);
            textBoxTestChar.Name = "textBoxTestChar";
            textBoxTestChar.Size = new Size(204, 23);
            textBoxTestChar.TabIndex = 11;
            textBoxTestChar.TextChanged += textBoxTestChar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 563);
            label2.Name = "label2";
            label2.Size = new Size(281, 15);
            label2.TabIndex = 12;
            label2.Text = "ввод символа для проверки его наличия в строке";
            // 
            // btnRemoveNegatives
            // 
            btnRemoveNegatives.Location = new Point(418, 386);
            btnRemoveNegatives.Name = "btnRemoveNegatives";
            btnRemoveNegatives.Size = new Size(186, 63);
            btnRemoveNegatives.TabIndex = 13;
            btnRemoveNegatives.Text = "удаление отрицательных элементов из массива.";
            btnRemoveNegatives.UseVisualStyleBackColor = true;
            btnRemoveNegatives.Click += btnRemoveNegatives_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 675);
            Controls.Add(btnRemoveNegatives);
            Controls.Add(label2);
            Controls.Add(textBoxTestChar);
            Controls.Add(label1);
            Controls.Add(textBoxTestString);
            Controls.Add(btnCheckChar);
            Controls.Add(btnCount);
            Controls.Add(btnDifference);
            Controls.Add(btnSum);
            Controls.Add(btnCompare);
            Controls.Add(btnArraySize);
            Controls.Add(btnCheckNegatives);
            Controls.Add(btnMultiply);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnMultiply;
        private Button btnCheckNegatives;
        private Button btnArraySize;
        private Button btnCompare;
        private Button btnSum;
        private Button btnDifference;
        private Button btnCount;
        private Button btnCheckChar;
        private TextBox textBoxTestString;
        private Label label1;
        private TextBox textBoxTestChar;
        private Label label2;
        private Button btnRemoveNegatives;
    }
}