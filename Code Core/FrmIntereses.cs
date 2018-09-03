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
    public partial class FrmIntereses : Form
    {
        //Evento para reiniciar el reloj en FrmPrincipal
        public delegate void BotonesInteresesClick(int x);
        public event BotonesInteresesClick ReinicioReloj;
        //Evento para cambiar el texto del bocadillo en FrmPrincipal
        public delegate void txtMiDialogoChange(string s);
        public event txtMiDialogoChange CambiarTextoPrincipal;
        //Evento para cambiar la foto en FrmPrincipal
        public delegate void imgPrincipalChange(string s);
        public event imgPrincipalChange CambiarImagenPrincipal;
        //Evento para hacer aparecer el boton de juegos
        public delegate void revelarBoton();
        public event revelarBoton ApareceBoton;
        public FrmIntereses()
        {
            InitializeComponent();
        }
        private void BotonClick(object sender, EventArgs e)
        {
            //capturamos el nombre del control Boton que se ha pulsasdo
            string nombreBoton = ((Control)sender).Name;
            //Disparamos el evento que reinicia el reloj en FrmPrincipal
            ReinicioReloj(0);
            switch (nombreBoton)
            {
                case "btnVideojuegos":
                    CambiarImagenPrincipal("gamer");
                    CambiarTextoPrincipal("Los videojuegos me han acompañado desde que tengo memoria. " +
                        "Esa fue la razón que me llevó a soñar con crear mis propios juegos. " +
                        "Luego descubrí que habia que aprender a programar, y poco despues no solo aprendí " +
                        "a programar, también que el desarrollo de todo tipo de software era mi vocacion. " + 
                        "¡Nos vemos en Steam!");
                    ApareceBoton();
                    break;
                case "btnMusica":
                    CambiarImagenPrincipal("rock");
                    CambiarTextoPrincipal("Me casaría con la musica si pudiera, si bien soy muy selecto con " +
                        "el momento, lugar y género que escuchar cuando soy yo el que decide poner música. " +
                        "El Rock y la melodía instrumental siempre serán mi predilección, sin despreciar " +
                        "a los demás géneros. Eso si, todo lo que se le parezca al reggeaeton me transporta... " +
                        "a otra sala por ejemplo.");
                    break;
                case "btnAnimacion":
                    CambiarImagenPrincipal("aviso");
                    CambiarTextoPrincipal("Que nadie te diga jamas que los dibujos animados son para niños. " +
                        "Crecí con el mejor anime japonés, la edad de oro de Cartoon Network y una infinidad " +
                        "de series y peliculas animadas. A día de hoy sigo disfrutando de ellos como el que más.");
                    break;
                case "btnLiteratura":
                    CambiarImagenPrincipal("lectura");
                    CambiarTextoPrincipal("Fantasía, misterio y ciencia ficción, en ese orden. " +
                        "He leido obras como El Quijote (version sin censurar) y La Biblia porque era gratis " +
                        "y me he perdido en la mente de Neil Gaiman y Patrick Rothfuss. Luego está Terry Pratchett, " +
                        "cuyo Mundodisco me cambió para siempre.");
                    break;
                case "btnProgramar":
                    CambiarImagenPrincipal("boss");
                    CambiarTextoPrincipal("¿Crees que me habria copado este pedazo curriculum " +
                        "interactivo porque un dia me levanté y dije 'habrá que hacer algo con la bida'? " +
                        "Nein mai frend. Desarrollar software y todo lo que lo rodea se pasó rápidamente de ser " +
                        "un requisito a ser una vocación.");
                    break;
                case "btnCine":
                    CambiarImagenPrincipal("meh");
                    CambiarTextoPrincipal("Sigue las mismas pautas que la literatura, aunque con el cine soy menos " +
                        "quisquilloso. Poner una película de animación de cualquier clase es de las pocas formas " +
                        "que existen de tenerme quieto y callado, despues de jugar videojuegos, programar o leer.");
                    break;
            }
        }
        private void FrmIntereses_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
