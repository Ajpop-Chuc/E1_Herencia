using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace E1_Herencia
{
    public class Universidad
    {
        public string nombre { get; set; }
        public string sede { get; set; }
        public List<Alumno> listaAlumnos { get; set; }

        public static List<Universidad> listaUniversidad = new List<Universidad>();

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaUniversidad);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaUniversidad = JsonConvert.DeserializeObject<List<Universidad>>(json);
        }
    }

}