using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E1_Herencia
{
    public class Catedrático:Persona
    {
        string titulo;

        public string Titulo { get => titulo; set => titulo = value; }
    }
}