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
    public partial class FrmParejas : Form
    {
        bool cerrojo, botonPulsado = false;
        Button pareja1, pareja2 = new Button();
        int tiempo, puntuacion, numMovimientos, i = 0;
        int numParejas = 0;
        //Array numerico que nos servirá para asignar 32 parejas numericas a los 64 botones.
        int[] array = {0,0,1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15,16,16,17,17,18,18,19,19,20,20,21,21,22,22,23,23,24,24,25,25,26,26,27,27,28,28,29,29,30,30,31,31};
        public FrmParejas()
        {
            InitializeComponent();
        }
        //Eventos
        private void FrmParejas_Load(object sender, EventArgs e)
        {
            lblNumParejas.Text = "" + numParejas;
            lblMovimientos.Text = "" + numMovimientos;
            lblTiempo.Text = "0:0";
            tmrMemory.Start();
            //Utilizando un algoritmo, desordenamos el array numerico cada vez que cargamos el formulario.
            array = Utilidades.Desordenar(array);
            //Recorremos los controles del formulario asignando los valores desordenados.
            foreach (Control ctrl in this.Controls)
            {
                //Si el nombre del boton contiene "button" realizamos lo siguiente.
                //Esto sirve para poder agregar mas botones en caso de necesitarlo
                //sin que se vean afectados.
                if (ctrl is Button && ctrl.Name.Contains("button"))
                {
                    ctrl.Tag = array[i];
                    i+=1;
                }
            }
        }
        private void BotonesParejasClick(object sender, EventArgs e)
        {
            //Este 'cerrojo' evitara que podamos hacer click hasta que no desaparezcan las imagenes desemparejadas
            if (cerrojo == false)
            {
                //Asignamos una imagen de nuestra carpeta de imagenes dinamicamente usando la variable Tag.
                ((Button)sender).Image = Image.FromFile(@"ImgParejas\b" + ((Button)sender).Tag + ".jpg");
                if (botonPulsado == false)
                {
                    //Capturamos el primer boton pulsado y lo referenciamos.
                    pareja1 = ((Button)sender);
                    //Aseguramos la entrada en el 'else' mediante este segundo 'cerrojo'.
                    botonPulsado = true;
                    //Eliminamos el evento de dicho boton de modo que no se pueda crear una pareja con el mismo boton.
                    ((Button)sender).Click -= BotonesParejasClick;
                }
                else
                {
                    numMovimientos++;
                    lblMovimientos.Text = "" + numMovimientos;
                    //Capturamos el segundo boton pulsado y lo referenciamos.
                    pareja2 = ((Button)sender);
                    //Si las variables Tag coinciden, eliminamos los eventos click de ambos botones.
                    if ("" + pareja1.Tag == "" + pareja2.Tag)
                    {
                        pareja1.Click -= BotonesParejasClick;
                        pareja2.Click -= BotonesParejasClick;
                        //Incrementamos en 1 el numero de parejas.
                        numParejas++;
                        lblNumParejas.Text = "" + numParejas;
                        //Comprobamos si el juego ha terminado al conseguir las 32 parejas.
                        if (numParejas == 32)
                        {
                            //Paramos el reloj
                            tmrMemory.Stop();
                            puntuacion = 600 - tiempo;
                            //Llamamos a FrmPuntuacionParejas para introducir un registro
                            FrmPuntuacionParejas F_PuntuacionParejas = new FrmPuntuacionParejas(puntuacion, Convert.ToString(tiempo));
                            F_PuntuacionParejas.ShowDialog();
                            //Mostramos las mejores puntuaciones
                            FrmMejoresParejas F_MejoresParejas = new FrmMejoresParejas();
                            F_MejoresParejas.ShowDialog();
                            //Preguntamos si vamos a jugar de nuevo.
                            //En caso afirmativo repetimos todos los pasos iniciales para restaurarlo todo.
                            DialogResult dialogResult = MessageBox.Show("¿Reiniciar?", "Memory / Parejas", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                array = Utilidades.Desordenar(array);
                                cerrojo = botonPulsado = false;
                                tiempo = puntuacion = numMovimientos = i = numParejas = 0;
                                lblNumParejas.Text = "" + numParejas;
                                pareja1 = pareja2 = null;
                                foreach (Control ctrl in this.Controls)
                                {
                                    if (ctrl is Button && ctrl.Name.Contains("button"))
                                    {
                                        ((Button)ctrl).Image = null;
                                        ctrl.Click -= BotonesParejasClick;
                                        ctrl.Click += BotonesParejasClick;
                                        ctrl.Tag = array[i];
                                        i++;
                                    }
                                }
                                tmrMemory.Start();
                            }
                            else
                            {
                                this.Dispose();
                            }
                        }
                    }
                    else
                    {
                        //Iniciamos un reloj cuyo tick dura 2 segundos.
                        tmrParejas.Start();
                        //Activamos el cerrojo hasta que el evento tick haya ocurrido
                        cerrojo = true;
                        //Devolvemos el evento al primer boton.
                        pareja1.Click += BotonesParejasClick;
                    }
                    //Abrimos el segundo cerrojo para poder volver a intentar hacer una pareja.
                    botonPulsado = false;
                }
            }
        }
        private void btnPuntuaciones_Click(object sender, EventArgs e)
        {
            tmrMemory.Stop();
            FrmMejoresParejas F_MejoresParejas = new FrmMejoresParejas();
            F_MejoresParejas.ShowDialog();
            tmrMemory.Start();
        }
        //Temporizadores
        private void tmrParejas_Tick(object sender, EventArgs e)
        {
            //Paramos el reloj para que el evento tick ocurra solo una vez.
            tmrParejas.Stop();
            //Eliminamos las imagenes de los botones.
            pareja1.Image = null;
            pareja2.Image = null;
            //Ya podemos volver a intentarlo.
            cerrojo = false;
        }
        private void tmrMemory_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblTiempo.Text = "" + tiempo / 60 + ":" + tiempo % 60;
        }
        private void FrmParejas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
