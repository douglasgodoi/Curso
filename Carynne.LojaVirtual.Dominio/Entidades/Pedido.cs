﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carynne.LojaVirtual.Dominio.Entidades
{
    public class Pedido
    {
        [Required(ErrorMessage="Informe seu nome")]
        public string NomeCliente { get; set; }
        
        [Display(Name ="Cep:")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe sua cidade")]
        [Display(Name ="Cidade:")]
        public string Cidade { get; set; }

        [Display(Name ="Complemento:")]
        public string complemento { get; set; }

        [Required(ErrorMessage = "Informe seu bairro")]
        [Display(Name ="Bairro:")]
        public string bairro { get; set; }

        [Required(ErrorMessage = "Informe seu e-mail")]
        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }

        [Display(Name ="Embrulhar para presente:")]
        public bool EmbrulharPresente { get; set; }
    }
}
