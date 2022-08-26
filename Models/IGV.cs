using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class IGV
    {
        [Display( Name = "Nombre")]
       
        public string Operador1 {get;set;} 

        [Display( Name = "Kilogramos")]
        public int Operador2 {get;set;} 

        [Display( Name = "Unidad", Prompt ="Ingrese unidad")]
         public string Operador3 {get;set;} 

        [Display( Name = "Precio")]
         public int Pre {get;set;}
    }
}