using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Conozca_a_su_nuevo_empleado
{
    //Agarrate que vienen baches...
    public partial class FrmMejoresParejas : Form
    {
        //Una conexion que contendra una cadena de conexion.
        SqlConnection cnConexionBD;
        //El DataAdapter que servira de intermediario entre nuestro DataSet y la Base de Datos.
        SqlDataAdapter daJuegos;
        //El DataSet que contendra los datos a modificar de nuestra Base de Datos.
        DataSet dsJuegos = new DataSet();
        //Un DataRow que nos permita manipular filas en las tablas del DataSet.
        DataRow drFilaParejas;
        //un entero para usar mas tarde
        int tiempo = 0;
        //De momento no necesitamos nada mas.
        public FrmMejoresParejas()
        {
            InitializeComponent();
        }
        private void FrmMejoresParejas_Load(object sender, EventArgs e)
        {
            //Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            //Especificamos la cadena de conexion, que es la direccion de la Base de Datos que vamos a utilizar.
            //Esta cadena de conexion busca la Base de Datos ubicada en el mismo directorio que el .exe.
            //cnConexionBD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\JuegosBD.mdf;Integrated Security=True");
            cnConexionBD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Cne\JuegosBD.mdf;Integrated Security=True");
            //Especificamos una sentencia SELECT en nuestro DataAdapter que recoja los datos que vamos a utilizar.
            daJuegos = new SqlDataAdapter("SELECT * FROM Parejas ORDER BY Puntuacion DESC", cnConexionBD);
            //Mediante un SQLCommandBuilder ejecutamos la sentencia SELECT.
            SqlCommandBuilder constructorSQL = new SqlCommandBuilder(daJuegos)
            //Abrimos la conexion.
            cnConexionBD.Open();
            //Introducimos los datos obtenidos por la sentencia SELECT y los introducimos en el DataSet.
            daJuegos.Fill(dsJuegos, "Parejas");
            //Con los datos ya obtenidos, cerramos la conexion hasta volver a necesitarlo.
            cnConexionBD.Close();
            //Este FOR recorre las filas de la tabla Parejas y muestra sus valores en distintos controles Label.
            //El nombre de los label (Propiedad: Name) esta espécificamente pensado para que este bucle los encuentre
            //mediante la propiedad Name.
            for (int i = 0; i < dsJuegos.Tables["Parejas"].Rows.Count && i < 10; i++)
            {
                //Asignamos a nuestra fila una fila de la tabla Parejas
                drFilaParejas = dsJuegos.Tables["Parejas"].Rows[i];
                //Buscamos el Label con el nombre especifico que queremos para que muestre el valor
                //de una columna de la fila.
                this.Controls["lblJugadorPos" + i].Text = drFilaParejas["Jugador"].ToString();
                tiempo = Convert.ToInt32(drFilaParejas["Tiempo"]);
                this.Controls["lblTiempoPos" + i].Text = "" + tiempo / 60 + ":" + tiempo % 60;
                this.Controls["lblPuntosPos" + i].Text = drFilaParejas["Puntuacion"].ToString();
            }
        }
        private void btnBorrarPuntos_Click(object sender, EventArgs e)
        {
            //Siempre hay que preguntar antes de hacer cualquier barbaridad.
            DialogResult dialogResult = MessageBox.Show("¿Seguro segurisimo de verdad verdadera?", "Memory / Parejas", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //dsJuegos.Tables["Parejas"].Rows.Clear(); //ESTO NO FUNCIONA
                //Como "dsJuegos.Tables["Parejas"].Rows.Clear()" aparentemente no funciona probamos otra cosa.
                //Recorremos fila por fila de la tabla Parejas y la borramos, que remedio.
                for (int i = dsJuegos.Tables["Parejas"].Rows.Count; i > 0; i--)
                {
                    drFilaParejas = dsJuegos.Tables["Parejas"].Rows[i-1];
                    drFilaParejas.Delete();
                }//ESTO SI FUNCIONA
                //Esto...¡No!..¡TIENE!...¡¡¡NINGUN SENTIIIDOOOO!!!
                //Este IF solo se ejecuta si el DataSet tiene cambios.
                if (dsJuegos.HasChanges())
                {
                    //Actualizamos la base de datos mediante nuestro DataAdapter.
                    //Le pasamos el DataSet con los datos finales.
                    daJuegos.Update(dsJuegos, "Parejas");
                }
                this.Dispose();
            }
        }
        private void FrmMejoresParejas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
