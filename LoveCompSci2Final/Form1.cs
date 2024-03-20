namespace LoveCompSci2Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;

            Translate T = new Translate(text);

            txtTranslate.Text = T.ConvertAlt();

            string fulltext = txtText.Text;
            string[] words = fulltext.Split(' ');
            string[] sentence = fulltext.Split("\n");
            int wordCount = words.Length;
            int lineCount = sentence.Length;

            lblNumWords.Text = $"Number of words: {wordCount}";
            lblNumLines.Text = $"Number of lines: {lineCount}";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // allows the user to read from file

            string filepath = txtFile.Text;

            //string filepath = @"C:\Users\nate1\Desktop\header test.txt";
            string line;
            try
            {
                StreamReader sr = new StreamReader(filepath);

                line = sr.ReadLine();

                while (line != null)
                {
                    txtText.Text = txtText.Text + line + Environment.NewLine;
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // allows the user to browse for the file they want to open
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = open.FileName;
            }
        }

        private void btnSaveMarkdown_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txtText.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txtTranslate.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtText.Clear();
            txtTranslate.Clear();
            lblNumLines.Text = "Number of lines:";
            lblNumWords.Text = "Number of words:";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
