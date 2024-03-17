using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oti2018_national.Forms
{
    public partial class Generare_Traseu : Form
    {
        public Generare_Traseu()
        {
            InitializeComponent();
        }

        private void Generare_Traseu_Load(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Green);
            Point[] puncte = new Point[100];

            using (StreamReader rdr = new StreamReader("Harti\\RomaniaMare.txt"))
            {
                int i = 0;
                while(rdr.Peek() != -1)
                {
                    var line = rdr.ReadLine().Split('*');
                    puncte[i] = new Point { X = Int16.Parse(line[0]), Y = Int16.Parse(line[1]) };
                    i++;
                }
            }

            
        }

        private void gentrasBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "traseu.png";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
