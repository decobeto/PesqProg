using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PesqProg.Models
{
    public class ProgResponse
    {
        [Required(ErrorMessage="Informe o nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Informe o Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Informe a Idade")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Informe o Sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Informe se trabalha na area")]
        public bool? TrabalhaArea { get; set; }

        public List<CheckboxItemProg> ItemProgs { get; set; }
    }
}
