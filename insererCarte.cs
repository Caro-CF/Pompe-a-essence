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
    public partial class insererCarte : UserControl
    {

        public delegate void DelegateClickButton(string bouton);
        public event DelegateClickButton clickBtn;
        public insererCarte()
        {
            InitializeComponent();            
        }

        private void insererCarte_Load(object sender, EventArgs e)
        {

        }

        private void Vue_clickBtn(string bouton)
        {
            
        }

        private void btInsererCarte_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Name);
            }

        }
    }
}
