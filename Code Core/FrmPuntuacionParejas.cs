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
    public partial class FrmPuntuacionParejas : Form
    {
        //Declaramos los elementos que nos haran falta para manejar la base de datos.
        //Recordemos incluir 'System.Data.SqlClient' para poder hacerlo.
        SqlConnection cnConexionBD;
        SqlDataAdapter daJuegos;
        DataSet dsJuegos = new DataSet();
        DataRow drNuevaFila;
        int puntosObtenidos;
        string tiempoTranscurrido;
        public FrmPuntuacionParejas()
        {
            InitializeComponent();
        }
        //Sobrecargamos el constructor para que reciba la puntuacion y el tiempo desde el formulario padre (FrmParejas).
        public FrmPuntuacionParejas(int puntos, string tiempo) : this()
        {
            puntosObtenidos = puntos;
            tiempoTranscurrido = tiempo;
        }
        private void FrmPuntuacionParejas_Load(object sender, EventArgs e)//C:\Users\Rhys\source\repos\Conozca a su nuevo empleado\Conozca a su nuevo empleado\JuegosBD.mdf
        {
            //Establecemos la direccion a la que queremos conectar la BD.
            cnConexionBD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Cne\JuegosBD.mdf;Integrated Security=True");
            //Establecemos comando Select en el DataAdapter y le pasamos la conexion a la BD.
            daJuegos = new SqlDataAdapter("SELECT * FROM Parejas", cnConexionBD);
            //Construimos del DataAdapter
            SqlCommandBuilder constructorSQL = new SqlCommandBuilder(daJuegos);
            //Abrimos la conexion.
            cnConexionBD.Open();
            //Llenamos el DataSet
            daJuegos.Fill(dsJuegos, "Parejas");
            //Cerramos la conexion
            cnConexionBD.Close();
            lblPuntuacion.Text = "¡Bien hecho! ¡Tu puntuacion es de " + puntosObtenidos + " puntos. Introduce tu nombre.";
            //oDataRow = oDataSet.Tables("Alumnos").NewRow
            drNuevaFila = dsJuegos.Tables["Parejas"].NewRow();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Asignamos valores a la nueva fila a insertar en la tabla Parejas
            //Le damos un valor a 'Id' para que en la fila no tenga valor NULL
            //sin embargo, mediante las propiedades de la BD este campo se autoincrementa solo.
            drNuevaFila["Id"] = 1;
            //Por si el jugador es un trolazo...
            if (txtNombre.Text == "")
            {
                drNuevaFila["Jugador"] = "Anónimo";
            }
            else
            {
                drNuevaFila["Jugador"] = txtNombre.Text;
            }
            drNuevaFila["Tiempo"] = tiempoTranscurrido;
            drNuevaFila["Puntuacion"] = puntosObtenidos;
            //Añadimos la nueva fila al DataSet.
            dsJuegos.Tables["Parejas"].Rows.Add(drNuevaFila);
            //Actualizamos la BD
            if (dsJuegos.HasChanges())
            {
                daJuegos.Update(dsJuegos, "Parejas");
            }
            this.Dispose();
        }
        private void FrmPuntuacionParejas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
