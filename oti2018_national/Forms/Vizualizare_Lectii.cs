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
    public partial class Vizualizare_Lectii : Form
    {
        public UserModel user;
        public Vizualizare_Lectii()
        {
            InitializeComponent();
        }

        public DataManagement data = new DataManagement();
        public List<LectieModel> lectii;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "ContinutLectii//" + lectii[Int16.Parse(listBox1.SelectedIndex.ToString())].imagine + ".bmp";
            UserModel user = data.getlessonowner(lectii[Int16.Parse(listBox1.SelectedIndex.ToString())].id_util);
            textBox2.Text = user.nume + "\n" + user.email + "\n" + lectii[Int16.Parse(listBox1.SelectedIndex.ToString())].regiune + "\n" + lectii[Int16.Parse(listBox1.SelectedIndex.ToString())].datacrearii.ToString();
        }

        private void Vizualizare_Lectii_Load(object sender, EventArgs e)
        {
            lectii = data.getlectii();

            foreach(LectieModel model in lectii)
            {
                listBox1.Items.Add(model.nume);
            }
        }

        private void createlessonBtn_Click(object sender, EventArgs e)
        {
            Creare_Lectie cr = new Creare_Lectie();
            this.Hide();
            cr.ShowDialog();
        }

        private void gentraseuBtn_Click(object sender, EventArgs e)
        {
            Generare_Traseu cr = new Generare_Traseu();
            this.Hide();
            cr.ShowDialog();
        }
    }
}
