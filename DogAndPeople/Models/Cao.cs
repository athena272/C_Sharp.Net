using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogAndPeople.Models
{
    public class Cao
    {
        [Key]
        public int ID_CAO { get; set; }
        public string NOME_CAO { get; set; }
        public string ID_RACA { get; set; }
    }
}