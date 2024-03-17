using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oti2018_national.Forms
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
        }

        public UserModel user;

        private List<string> correctimages = new List<string>();
        private void Captcha_Load(object sender, EventArgs e)
        {
            List<string> images = new List<string>();
            

            string filepath = "Captcha\\";
            string filepathoameni = "oameni.txt";
            foreach(string image in Directory.GetFiles(filepath))
            {
                images.Add(image);
            }
            using(StreamReader sr = new StreamReader(filepathoameni))
            {
                while(sr.Peek() > 0)
                {
                    string line = sr.ReadLine().TrimEnd();
                    correctimages.Add(line);
                }
            }


            Random rand = new Random();
            int x = rand.Next(0, 20);
            pictureBox1.Image = Image.FromFile(images[x]);
            
            x = rand.Next(0, 20);
            pictureBox2.Image = Image.FromFile(images[x]);
            
            x = rand.Next(0, 20);
            pictureBox3.Image = Image.FromFile(images[x]);
            
            x = rand.Next(0, 20);
            pictureBox4.Image = Image.FromFile(images[x]);
            
            x = rand.Next(0, 20);
            pictureBox5.Image = Image.FromFile(images[x]);
            
            x = rand.Next(0, 20);
            pictureBox6.Image = Image.FromFile(images[x]);
            
            
        }

        private List<string> selectedimages = new List<string>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string test = pictureBox1.ImageLocation;
            selectedimages.Add(pictureBox1.ImageLocation);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedimages.Add(pictureBox2.ImageLocation.ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedimages.Add(pictureBox3.ImageLocation.ToString());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectedimages.Add(pictureBox2.ImageLocation.ToString());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectedimages.Add(pictureBox5.ImageLocation.ToString());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectedimages.Add(pictureBox6.ImageLocation.ToString());
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            int k = 0;
            foreach(string s in selectedimages)
            {
                foreach(string s2 in correctimages)
                {
                    if (s == s2)
                    {
                        k++;
                    }
                }
            }

            if(k == 6)
            {
                MessageBox.Show("ok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataManagement data = new DataManagement();
            data.changepass(user.email, textBox2.Text);
        }
    }
}
