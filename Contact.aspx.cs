using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E1_Herencia
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(!IsPostBack)
            {
                string notas="  ";
                List<double> notasSalvadas = new List<double>();
                string archivo = Server.MapPath("Datos.json");
                Alumno.leerTXT(archivo);
                GridView1.DataSource = null;
                GridView1.DataBind();
                GridView1.DataSource = Alumno.listaDatosAlumno;
                GridView1.DataBind();
                foreach(var x in Alumno.listaDatosAlumno)
                {
                    foreach(var x2 in x.Notas)
                    {
                        notasSalvadas.Add(x2);
                    }
                    
                }
                GridView2.DataSource = null;
                GridView2.DataBind();
                GridView2.DataSource = notasSalvadas;
                GridView2.DataBind();
            }*/
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}