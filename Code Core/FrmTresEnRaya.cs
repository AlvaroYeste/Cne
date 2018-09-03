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
    public partial class FrmTresEnRaya : Form
    {
        bool turnoRojo = true;
        int i, botonesPulsados = 0;
        public FrmTresEnRaya()
        {
            InitializeComponent();
        }
        private void finJuego()
        {
            i = 10;
            botonesPulsados = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Click -= BotonesRaya_Click;
                }
            }
            DialogResult dialogResult = MessageBox.Show("¿Reiniciar?", "Tres en Raya", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        ((Button)ctrl).Image = null;
                        ctrl.Click += BotonesRaya_Click;
                        ctrl.Tag = i;
                        i++;
                    }
                }
            }
            else
            {
                this.Dispose();
            }
        }
        private void BotonesRaya_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= BotonesRaya_Click;
            botonesPulsados++;
            if (turnoRojo == true)
            {
                ((Button)sender).Image = Image.FromFile(@"ImgTresRaya\circulo.jpg");
                ((Button)sender).Tag = 1;
                turnoRojo = false;
            }
            else
            {
                ((Button)sender).Image = Image.FromFile(@"ImgTresRaya\equis.png");
                ((Button)sender).Tag = 0;
                turnoRojo = true;
            }
            if(Convert.ToInt32(button1.Tag) == Convert.ToInt32(button2.Tag) && Convert.ToInt32(button2.Tag) == Convert.ToInt32(button3.Tag))
            {
                if (Convert.ToInt32(button1.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button4.Tag) == Convert.ToInt32(button5.Tag) && Convert.ToInt32(button5.Tag) == Convert.ToInt32(button6.Tag))
            {
                if (Convert.ToInt32(button4.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button7.Tag) == Convert.ToInt32(button8.Tag) && Convert.ToInt32(button8.Tag) == Convert.ToInt32(button9.Tag))
            {
                if (Convert.ToInt32(button7.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button1.Tag) == Convert.ToInt32(button4.Tag) && Convert.ToInt32(button4.Tag) == Convert.ToInt32(button7.Tag))
            {
                if (Convert.ToInt32(button1.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button2.Tag) == Convert.ToInt32(button5.Tag) && Convert.ToInt32(button5.Tag) == Convert.ToInt32(button8.Tag))
            {
                if (Convert.ToInt32(button2.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button3.Tag) == Convert.ToInt32(button6.Tag) && Convert.ToInt32(button6.Tag) == Convert.ToInt32(button9.Tag))
            {
                if (Convert.ToInt32(button3.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button1.Tag) == Convert.ToInt32(button5.Tag) && Convert.ToInt32(button5.Tag) == Convert.ToInt32(button9.Tag))
            {
                if (Convert.ToInt32(button1.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (Convert.ToInt32(button3.Tag) == Convert.ToInt32(button5.Tag) && Convert.ToInt32(button5.Tag) == Convert.ToInt32(button7.Tag))
            {
                if (Convert.ToInt32(button3.Tag) == 1)
                {
                    MessageBox.Show("Gana rojo");
                }
                else
                {
                    MessageBox.Show("Gana negro");
                }
                finJuego();
            }
            else if (botonesPulsados == 9)
            {
                MessageBox.Show("Empate");
                finJuego();
            }
        }
    }
}
