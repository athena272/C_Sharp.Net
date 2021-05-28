using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cursinho.Models
{
    public class Turma
    {

        [Key]
        public int IdTurma { get; set; }

        [Display(Name = "Curso")]
        public int IdCurso { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Nome da Turma")]
        public string DescricaoTurma { get; set; }
        [Range(0, 60)]

        [Display(Name = "Quantidade de Alunos")]
        public int QtdeAlunos { get; set; }

        [Required(ErrorMessage = "O campo Turno é obrigatório.")]
        public string Turno { get; set; }
        public bool Ativo { get; set; }

        public virtual string nomeCurso { get; set; }

    }
}