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
    public partial class FrmInfoPersonal : Form
    {
        public FrmInfoPersonal()
        {
            InitializeComponent();
        }

        private void lblLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://es.linkedin.com/in/alvaro-yeste-a0b50178");
            }
            catch (Exception error)
            {
                MessageBox.Show("¿Tienes un explorador de internet? ¿Esto te dice algo? "+error);
            }
            
        }

        private void FrmInfoPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
