using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class fm : Form
    {
        int count = 0;
        Random rnd = new Random();

        public fm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет! Меня зовут Денис! \nЭту программу я написал 14.06.17","Инфо");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            lbCount.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count--;
            lbCount.Text = count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            lbCount.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = rnd.Next(Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(numericUpDown2.Value));
            lbGenerate.Text = n.ToString();
            if (cbRandom.Checked)
            {
                if (tbGenerate.Text.IndexOf(n.ToString()) == -1) tbGenerate.AppendText(n + " ");

            }
            else
                tbGenerate.AppendText(n + " ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbGenerate.Clear();
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbGenerate.Text);
        }

        private void tsmiPasteTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiPasteDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }

        private void tsmiPasteHello_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText("С уважением, Денис. \nт.8-952-951-50-61 \n ipscvrn@icloud.com");
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении");
            }
        }
        
        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }
    }
}
