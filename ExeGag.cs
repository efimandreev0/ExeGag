using System.Text;
namespace BinaryEditor
{
    public partial class ExeGag : Form
    {
        public static string file;
        public static Encoding encoding;
        public static long pos;
        public static int originalLen;
        public static int maxLen;
        public static BinaryReader reader;
        public ExeGag()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраните параметры в Parameters.txt
            File.WriteAllText("Parameters.txt", $"{offsetText.Text}\n{encodingText.Text}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxLen = 0;
            originalLen = 0;
            if (File.Exists("Parameters.txt"))
            {
                string[] f = File.ReadAllLines("Parameters.txt");
                offsetText.Text = f[0];
                encodingText.Text = f[1];
            }
        }
        private string ReadString()
        {
            reader.BaseStream.Position = pos;
            string s = Utils.ReadString(reader, encoding);
            originalLen = encoding.GetBytes(s).Length;
            maxLen = originalLen + Utils.SkipBytes(reader, 0);
            return s;
        }
        private void WriteString()
        {
            reader.Close();
            using (BinaryWriter writer = new(File.OpenWrite(file)))
            {
                writer.BaseStream.Position = pos;
                byte[] b = encoding.GetBytes(richTextBox1.Text);
                if (b.Length <= maxLen)
                {
                    writer.Write(b);
                    writer.Write(new byte[maxLen - b.Length]);
                }
                else
                {
                    for (int i = 0; i < maxLen; i++) writer.Write(b[i]);
                    MessageBox.Show($"Your phrase is too long. It pasted, but cutted to {maxLen} bytes.");
                }
                writer.Write((byte)0);
                pos = writer.BaseStream.Position;
            }
            reader = new(File.OpenRead(file));
            reader.BaseStream.Position = pos;
            offsetText.Text = pos.ToString("x8");
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            OpenFileDialog o = new();
            if (offsetText.Text != "Offset" && !string.IsNullOrEmpty(offsetText.Text))
            {
                if (encodingText.Text != "Encoding" && !string.IsNullOrEmpty(encodingText.Text))
                {
                    if (o.ShowDialog() == DialogResult.OK)
                    {
                        file = o.FileName;
                        pos = Convert.ToInt64(offsetText.Text, 16);
                        encoding = Encoding.GetEncoding(encodingText.Text);
                        reader = new(File.OpenRead(file));
                        richTextBox1.Text = ReadString();
                    }
                }
                else MessageBox.Show("Before opening file enter encoding.");
            }
            else MessageBox.Show("Before opening file enter offset.");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = $"Maximum text length: {maxLen.ToString("D4")}\n" +
                $"Original text length: {originalLen.ToString("D4")}\n" +
                $"Now text length: {encoding.GetBytes((richTextBox1.Text)).Length.ToString("D4")}";
        }

        private void encodingText_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(file)) WriteString();
            else MessageBox.Show("Before saving file open it.");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            WriteString();
            pos = reader.BaseStream.Position;
            offsetText.Text = pos.ToString("x8");
            richTextBox1.Text = ReadString();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find f = new(this);
            f.Show();
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.GetEncoding(encodingText.Text);
            pos = Convert.ToInt64(offsetText.Text, 16);
            offsetText.Text = pos.ToString("x8");
            richTextBox1.Text = ReadString();
        }
        public void goToFinded()
        {
            pos = Convert.ToInt64(offsetText.Text, 16);
            offsetText.Text = pos.ToString("x8");
            richTextBox1.Text = ReadString();
        }

        private void offsetText_Click(object sender, EventArgs e)
        {

        }
    }
}
