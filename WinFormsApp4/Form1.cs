using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private OneDimensionalArrayApp.OneDimensionalArray array1;
        private OneDimensionalArrayApp.OneDimensionalArray array2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������������� ��������
            array1 = new OneDimensionalArrayApp.OneDimensionalArray(1, 2, 3);
            array2 = new OneDimensionalArrayApp.OneDimensionalArray(4, 5, 6);

            // ����� ���������� � ��������
            richTextBox1.AppendText($"Array1: {string.Join(", ", array1)}\n");
            richTextBox1.AppendText($"Array2: {string.Join(", ", array2)}\n");
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            try
            {
                var result = array1 * array2;
                richTextBox1.AppendText($"Array1 * Array2: {string.Join(", ", result)}\n");
            }
            catch (ArgumentException ex)
            {
                richTextBox1.AppendText($"Error: {ex.Message}\n");
            }
        }

        private void btnCheckNegatives_Click_1(object sender, EventArgs e)
        {
            string isWithoutNegatives = array1.ContainsNegatives() ? "False" : "True";
            richTextBox1.AppendText($"Is array1 without negatives: {isWithoutNegatives}\n");
        }

        private void btnArraySize_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"Size of array1: {array1.Length}\n");
        }

        private void btnCompare_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"Are arrays equal: {array1 == array2}\n");
            richTextBox1.AppendText($"Is array1 shorter than array2: {array1 < array2}\n");
        }

        private void btnSum_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"Sum of array1: {OneDimensionalArrayApp.StatisticOperation.Sum(array1)}\n");
        }

        private void btnDifference_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"Difference between max and min of array1: {OneDimensionalArrayApp.StatisticOperation.Difference(array1)}\n");
        }

        private void btnCount_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"Count of elements in array1: {OneDimensionalArrayApp.StatisticOperation.Count(array1)}\n");
        }

        private void btnCheckChar_Click_1(object sender, EventArgs e)
        {
            string testString = textBoxTestString.Text;
            char testChar = textBoxTestChar.Text.FirstOrDefault();
            richTextBox1.AppendText($"Does \"{testString}\" contain character '{testChar}': {testString.Contains(testChar)}\n");
        }

        private void btnRemoveNegatives_Click_1(object sender, EventArgs e)
        {
            var newArray = array1.RemoveNegatives();
            richTextBox1.AppendText($"Array1 without negative elements: {string.Join(", ", newArray)}\n");
        }

        private void textBoxTestChar_TextChanged(object sender, EventArgs e)
        {
            // ��������� ������ �� ������ ������ � ���� �����
            char testChar = textBoxTestChar.Text.FirstOrDefault();
            // ������� ������ � ��������� ����
            richTextBox1.AppendText($"Updated test character: {testChar}\n");
        }

        private void textBoxTestString_TextChanged(object sender, EventArgs e)
        {
            // �������� ��������� ������ �� ���������� ����
            string testString = textBoxTestString.Text;

            // ���������, �������� �� ������ ������
            if (string.IsNullOrWhiteSpace(testString))
            {
                // ���� ������ �����, ������� ���������
                richTextBox1.AppendText("Please enter a non-empty string.\n");
                return;
            }

            // ����������� � ������������ ������ ��� ������
            string searchCharInput = PromptUserForSearchCharacter();

            // ���������, �������� �� ������ ������ ����� �������
            if (string.IsNullOrWhiteSpace(searchCharInput))
            {
                // ���� ������ �����, ������� ���������
                richTextBox1.AppendText("Please enter a valid search character.\n");
                return;
            }

            // �������� ������ ������ �� ��������� ������
            char searchChar = searchCharInput.First();

            // ���������, �������� �� ��������� ������ �������� ������
            bool containsChar = testString.Contains(searchChar);

            // ������� ��������� ��������
            richTextBox1.AppendText($"Does \"{testString}\" contain character '{searchChar}': {containsChar}\n");
        }

        private string PromptUserForSearchCharacter()
        {
            // ����������� � ������������ ������ ��� ������
            string input = Prompt.ShowDialog("Enter a character to search:", "Search Character Input");
            return input;
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
