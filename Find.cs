using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryEditor
{
    public partial class Find : Form
    {
        public Find(ExeGag gag)
        {
            g = gag;
            InitializeComponent();
        }
        public ExeGag g;

        public static string[] ReadFile(BinaryReader reader, byte[] b)
        {
            List<string> s = [];
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                byte[] bs = reader.ReadBytes(b.Length);
                if (bs.SequenceEqual(b) == true)
                    s.Add($"{(reader.BaseStream.Position - b.Length).ToString("x8")}\t\t{ExeGag.encoding.GetString(b)}");
                if (reader.BaseStream.Position < reader.BaseStream.Length) reader.BaseStream.Position -= b.Length - 1;
            }
            return s.ToArray();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            long pos = ExeGag.reader.BaseStream.Position;
            ExeGag.reader.BaseStream.Position = 0;
            if (FullBox.Checked) FindedLBox.Items.AddRange(ReadFile(ExeGag.reader, ExeGag.encoding.GetBytes(Utils.ConvertToFull(FindTextBox.Text))));
            else FindedLBox.Items.AddRange(ReadFile(ExeGag.reader, ExeGag.encoding.GetBytes(FindTextBox.Text)));
            ExeGag.reader.BaseStream.Position = pos;
        }

        private void FindedLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long pos = Convert.ToInt64(FindedLBox.Items[FindedLBox.SelectedIndex].ToString().Split("\t")[0], 16);
            ExeGag.pos = pos;
            ExeGag.reader.BaseStream.Position = pos;
            g.offsetText.Text = pos.ToString("x8");
            g.goToFinded();
        }
    }
}
