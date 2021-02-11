using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pompe_a_essence
{
    public partial class Vue : Form
    {
        Actions Actions = new Actions();

        public Vue()
        {
            InitializeComponent();
            insererCarte.clickBtn += InsererCarte_clickBtn;
           
            Actions.Show();      
            
                 
        }

        private void InsererCarte_clickBtn(string bouton)
        {
            if (bouton == "btInsererCarte")
            {               
               Actions.label2.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void insererCarte_Load(object sender, EventArgs e)
        {

        }
    }
}
