using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace E1_Herencia
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnosTemp = new List<Alumno>();
        static List<Nota> notasTemp = new List<Nota>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("Datos.json");
                Universidad.leerJson(archivo);

            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void ButtonInNotas_Click(object sender, EventArgs e)
        {
            Nota datosNota = new Nota();
            datosNota.curso = TextBoxCurso.Text;
            datosNota.punteo = Convert.ToInt16(TextBoxPunteo.Text);
            notasTemp.Add(datosNota);
            TextBoxCurso.Text = "";
            TextBoxPunteo.Text = "";
        }

        protected void ButtonInDatos_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Direccion = TextBoxDireccion.Text;
            alumno.FechaNacimiento = Calendar1.SelectedDate;
            alumno.Carne = TextBoxCarne.Text;
            alumno.Notas = notasTemp.ToArray().ToList();
            //alumno.Notas.CopyTo(notasTemp.ToArray());

            alumnosTemp.Add(alumno);
       
            notasTemp.Clear();

            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxCarne.Text = "";
        }

        protected void ButtonGuardarUniversidad_Click(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Datos.json");
            Universidad universidad = new Universidad();
            universidad.nombre = DropDownListUniversidad.SelectedValue;
            universidad.sede = TextBoxSede.Text;
            universidad.listaAlumnos = alumnosTemp.ToArray().ToList();
            Universidad.listaUniversidad.Add(universidad);
            Universidad.guardarenJson(archivo);

            alumnosTemp.Clear();
        }
    }
}