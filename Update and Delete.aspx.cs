using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E1_Herencia
{
    public partial class Update : System.Web.UI.Page
    {

        static Universidad DatosUni;
        static string carneSeleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("Datos.json");
                Universidad.leerJson(archivo);
                foreach (var x in Universidad.listaUniversidad)
                {
                    DropDownListUniversidad.Items.Add(x.nombre);
                }
            }

        }

        protected void ButtonSeleccionarUni_Click(object sender, EventArgs e)
        {
            DropDownListCarne.Items.Clear();
           
            DatosUni = Universidad.listaUniversidad.Find
            (i => i.nombre == DropDownListUniversidad.SelectedItem.ToString());
            
            foreach (var x in DatosUni.listaAlumnos)
            {
                DropDownListCarne.Items.Add(x.Carne);
            }
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            carneSeleccionado = DropDownListCarne.SelectedItem.ToString();

            
            Alumno alumno= DatosUni.listaAlumnos.Find(x => x.Carne == carneSeleccionado);
           
            TextBoxNombre.Text = alumno.Nombre;
            TextBoxApellido.Text = alumno.Apellido;
            TextBoxDireccion.Text = alumno.Direccion;
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumno = DatosUni.listaAlumnos.Find(x => x.Carne == carneSeleccionado);
            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Direccion = TextBoxDireccion.Text;
            string archivo = Server.MapPath("Datos.json");
            Universidad.guardarenJson(archivo);
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int alumno = DatosUni.listaAlumnos.FindIndex(x => x.Carne == carneSeleccionado);
            DatosUni.listaAlumnos.RemoveAt(alumno);
            string archivo = Server.MapPath("Datos.json");
            Universidad.guardarenJson(archivo);
        }
    }
}