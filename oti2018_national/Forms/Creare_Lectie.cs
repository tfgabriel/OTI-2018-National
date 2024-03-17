using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oti2018_national.Forms
{
    public partial class Creare_Lectie : Form
    {
        public Creare_Lectie()
        {
            InitializeComponent();
        }

        private int k;
        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "BMP Files|*.bmp;";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.RowCount * tableLayoutPanel1.GetRowHeights()[0]);
                tableLayoutPanel1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(saveFileDialog1.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel1, tableLayoutPanel1.RowCount + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel1, tableLayoutPanel1.ColumnCount + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel1, tableLayoutPanel1.RowCount - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel1, tableLayoutPanel1.ColumnCount - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tableLayoutPanel1.Controls.Add(new PictureBox { ImageLocation = openFileDialog1.FileName}, 0, 0);
                }
            }
            if( k == 0)
            {
                
                
                    tableLayoutPanel1.Controls.Add(new TextBox { Multiline = true, Text = "Moldova"}, 0, 1);
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            k = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            k = 1;
        }
    }
}
