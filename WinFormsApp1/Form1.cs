using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            toolStripProgressBar1.Value = 0;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                var dialogResult = MessageBox.Show("Progress bar is full");
                if (dialogResult == DialogResult.OK)
                {
                    statusStrip1.Visible = false;
                }
            }
        }

        private void contionueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stopToolStripMenuItem_Click(sender, e);
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contionueToolStripMenuItem_Click(sender, e);
        }
    }
}
