using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Conozca_a_su_nuevo_empleado
{
    public partial class FrmPrincipal : Form
    {
        int timecounter = 0; //cuenta los eventos tick del reloj.
        bool presentado, empezado, bool_experiencia, bool_objetivos = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)//el reloj se inicia aqui
        {
            tmrReloj.Start();
            imgPrincipal.Image = Image.FromFile(@"caras\cara_hola.jpg");
        }
        //no quiero que el parpadeo del cursor de escritura moleste, este codigo lo soluciona
        private void TxtMiDialogo_Click(object sender, EventArgs e)
        {
            imgBocadillo.Focus();
        }
        //eventos de reloj a continuacion
        private void TmrReloj_Tick(object sender, EventArgs e)
        {
            timecounter += 1;
            if (presentado == false)
            {
                if (timecounter == 15)
                {
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_contento.jpg");
                    txtMiDialogo.Text = "Pero antes de eso creo que le gustaría conocerme un poco mejor, para ello tiene a su disposicion el menú de la izquierda el cual le permitira navegar a traves de casi cualquier aspecto que desee, facil, sencillo y para toda la familia. ¿¡No es genial!? (2/2)";
                }
                if (timecounter == 30) //termina la presentacion, reseteamos el reloj
                {
                    presentado = true;
                    timecounter = 0;
                }
            }
            else //si nadie toca nada despues de presentarnos o cualquier otra accion, durante 60s empezamos la coña del aburrimiento
            {
                if (timecounter == 60)
                {
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_hey.jpg");
                    txtMiDialogo.Text = "Esto...¿Hola? ¿Hay alguien ahí? Me estoy aburriendo un poco.";
                }
                if (timecounter == 120)
                {
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_aburrido.jpg");
                    txtMiDialogo.Text = "¡Me abuuurrooooo!";
                }
            }
            //Segunda parte del dialogo Objetivos
            if (timecounter == 15 && bool_objetivos == true)
            {
                imgPrincipal.Image = Image.FromFile(@"caras\cara_y_punto.jpg");
                txtMiDialogo.Text = "Luego en el tema del crecimiento personal como desarrollador, a fecha " +
                    "de la creacion de este programa tengo intención de aprender C++, Ruby y Android. " +
                    "En un momento dado, si tengo que meterme con algun otro, pues se aprende y punto. (2/2)";
                bool_objetivos = false;
            }
            //Segunda parte del dialogo Experiencia
            if (timecounter == 10 && bool_experiencia == true)
            {
                imgPrincipal.Image = Image.FromFile(@"caras\cara_claro.jpg");
                txtMiDialogo.Text = "Pero eso es si hablamos de experiencia empresarial, estando contradado," +
                    "si hablamos de experiencia, cualquier tipo de experiencia, en programacion, ahi la cosa cambia un poco, " +
                    "porque de esa si que tengo, ya que desde que terminé los estudios no he parado. (2/3)";
            }
            if (timecounter == 25 && bool_experiencia == true)
            {
                imgPrincipal.Image = Image.FromFile(@"caras\cara_maybe.jpg");
                txtMiDialogo.Text = "Quién sabe, puede que algún dia tenga que modificar este boton para que muestre " +
                    "mi experiencia en el mundo del desarrollo de software, y eso no depende por completo de mi, " +
                    "yo puedo crear programas tan flipantes como este y tal, pero si no me contrata nadie... " +
                    "(guiño, guiño, codazo, codazo, patada en la espinilla) (3/3)";
                bool_experiencia = false;
            }
        }
        //eventos al hacer click en el panel principal a continuacion
        private void BotonesPanelClick(object sender, EventArgs e)
        {
            FrmInfoPersonal F_InfoPersonal = new FrmInfoPersonal();
            FrmIntereses F_Intereses = new FrmIntereses();
            FrmEstadisticas F_Estadisticas = new FrmEstadisticas();
            FrmHabilidades F_Habilidades = new FrmHabilidades();
            FrmFAQ F_FAQ = new FrmFAQ();
            FrmParejas F_Parejas = new FrmParejas();
            FrmTresEnRaya F_TresRaya = new FrmTresEnRaya();
            presentado = true;
            bool_experiencia = false;
            bool_objetivos = false;
            string nombreBoton = ((Control)sender).Name;
            if(empezado == false)
            {
                imgPrincipal.Image = Image.FromFile(@"caras\cara_empecemos.jpg");
                txtMiDialogo.Text = "¡Empecemos!";
                empezado = true;
            }// tonteria que dice "¡Empecemos!" o "Sigamos..." para mantener la continuidad.
            else
            {
                imgPrincipal.Image = Image.FromFile(@"caras\cara_sigamos.jpg");
                txtMiDialogo.Text = "Sigamos...";
            }
            timecounter = 0;
            //switch para controlar qué formulario abrir en base a que boton se pulsó en el panel principal
            switch(nombreBoton)
            {
                case "btnPanelInfoPersonal":
                    tmrReloj.Stop();
                    F_InfoPersonal.ShowDialog();
                    tmrReloj.Start();
                    break;
                case "btnPanelIntereses":
                    F_Intereses.ReinicioReloj += new FrmIntereses.BotonesInteresesClick(ResetearReloj);
                    F_Intereses.CambiarTextoPrincipal += new FrmIntereses.txtMiDialogoChange(CambioDeTexto);
                    F_Intereses.CambiarImagenPrincipal += new FrmIntereses.imgPrincipalChange(CambioDeImagen);
                    F_Intereses.ApareceBoton += new FrmIntereses.revelarBoton(JuegosVisible);
                    tmrReloj.Stop();
                    F_Intereses.ShowDialog();
                    tmrReloj.Start();
                    break;
                case "btnPanelObjetivos":
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_imagina.jpg");
                    txtMiDialogo.Text = "De publicar este programa terminado a ser contratado en desarrollo de " +
                        "software, del desarrollo de software a una carrera afianzada, de una carrera afianzada " +
                        " a la búsqueda del desarrollo de videojuegos y de ahi a...a...bueno, primero vamos a ver " +
                        "si llego a lo de la contratacion ¿eh? (1/2)";
                    bool_objetivos = true;
                    break;
                case "btnPanelEstadisticas":
                    tmrReloj.Stop();
                    F_Estadisticas.ShowDialog();
                    tmrReloj.Start();
                    break;
                case "btnPanelCurriculum":
                    //no se abre formulario, se abre un archivo que es el pdf del curriculum
                    try
                    {
                        string pdfPath = Path.Combine(Application.StartupPath, "Curriculum.pdf");
                        System.Diagnostics.Process.Start(pdfPath);
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("¿Tienes instalado Adobe Acrobat Reader? ¿Esto te dice algo? "+error);
                    }
                    break;
                case "btnPanelHabilidades":
                    tmrReloj.Stop();
                    F_Habilidades.ShowDialog();
                    tmrReloj.Start();
                    break;
                case "btnPanelExperiencia":
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_cero.jpg");
                    txtMiDialogo.Text = "¡Cero! ¡Nein! ¡Perkele! ¡Suka blyat! (1/3)";
                    bool_experiencia = true;
                    break;
                case "btnFAQ":
                    tmrReloj.Stop();
                    F_FAQ.ShowDialog();
                    tmrReloj.Start();
                    break;
                case "btnPanelSobreMi":
                    var resultado = Utilidades.FraseAleatoria();
                    txtMiDialogo.Text = resultado.Item1;
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_" + resultado.Item2 + ".jpg");
                    break;
                case "btnJuegos":
                    imgPrincipal.Image = Image.FromFile(@"caras\cara_contento.jpg");
                    txtMiDialogo.Text = "¿A qué quieres jugar?";
                    btnMemory.Visible = true;
                    btnTresEnRaya.Visible = true;
                    break;
                case "btnMemory":
                    tmrReloj.Stop();
                    F_Parejas.ShowDialog();
                    tmrReloj.Start();
                    break;
                case "btnTresEnRaya":
                    tmrReloj.Stop();
                    F_TresRaya.ShowDialog();
                    tmrReloj.Start();
                    break;
            }
        }
        //Metodos de eventos en FrmIntereses
        public void ResetearReloj(int a)
        {
            timecounter = a;
        }
        public void CambioDeTexto(string s)
        {
            txtMiDialogo.Text = s;
        }
        public void CambioDeImagen(string s)
        {
            imgPrincipal.Image = Image.FromFile(@"caras\cara_"+ s +".jpg");
        }
        public void JuegosVisible()
        {
            btnJuegos.Visible = true;
            btnJuegos.Text = Utilidades.TextoAleatorio();
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //www.youtube.com/watch?v=dQw4w9WgXcQ
            this.Dispose();
        }
    }
}
