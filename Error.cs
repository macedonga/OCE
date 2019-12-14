using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCE
{
    public partial class Error : Form
    {
        public Error(string errDesc, string exce)
        {
            InitializeComponent();
            errorDesc.Text = errDesc;
            exc.Text = exce;
        }
        private void Cont_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
