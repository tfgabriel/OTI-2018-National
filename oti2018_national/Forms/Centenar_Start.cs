using oti2018_national.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oti2018_national
{
    public partial class Centenar_Start : Form
    {
        public Centenar_Start()
        {
            InitializeComponent();
        }

        private void vizlectiiBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Vizualizare_Lectii vizlect = new Vizualizare_Lectii();
            vizlect.Show();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            
            Autentificare auth = new Autentificare();
            auth.ShowDialog();
            this.Hide();
        }
    }
}
