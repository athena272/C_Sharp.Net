using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogAndPeople.Models
{
    public class Dono
    {
        [Key]
        public int ID_DONO { get; set; }
        public string NOME_DONO { get; set; }
    }
}