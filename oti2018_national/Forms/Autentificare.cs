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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private DataManagement dataManager = new DataManagement();

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel
            {
                email = textBox1.Text,
                password = textBox2.Text
            };
            

            if (dataManager.checkuserindb(user) != null)
            {
                this.Hide();
                Vizualizare_Lectii vizlec = new Vizualizare_Lectii();
                if(vizlec.ShowDialog() == DialogResult.OK)
                {
                    vizlec.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("esti bou");
            }
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            dataaccess.LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserModel user = dataManager.checkuserindb(new UserModel { email = textBox1.Text, password = textBox2.Text });
            if(user != null)
            {
                this.Hide();
                Captcha captcha = new Captcha
                {
                    user = user
                };
                captcha.ShowDialog();
            }
        }
    }
}
