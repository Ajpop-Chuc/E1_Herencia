using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace E1_Herencia
{
    public class Alumno:Persona
    {
        private string carne;
        private List<Nota> notas = new List<Nota>();

        public List<Nota> Notas { get => notas; set => notas = value; }
        public string Carne { get => carne; set => carne = value; }

        
    }
}