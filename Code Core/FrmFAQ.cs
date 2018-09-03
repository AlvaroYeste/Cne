using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conozca_a_su_nuevo_empleado
{
    public partial class FrmFAQ : Form
    {
        public FrmFAQ()
        {
            InitializeComponent();
        }

        private void FrmFAQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
