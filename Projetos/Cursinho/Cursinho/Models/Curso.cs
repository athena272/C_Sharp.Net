using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cursinho.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 3)]

        [Display(Name = "Nome do Curso")]
        public string DescricaoCurso { get; set; }
        public bool Ativo { get; set; }
    }
}