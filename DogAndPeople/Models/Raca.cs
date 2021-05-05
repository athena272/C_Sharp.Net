using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogAndPeople.Models
{
    public class Raca
    {
        [Key]
        public int ID_RACA { get; set; }
        public string NOME_RACA { get; set; }
    }
}