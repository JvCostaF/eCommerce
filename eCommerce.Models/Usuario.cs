using System;
using System.Collections.Generic;

namespace eCommerce.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }    
        public string? Email { get; set; }
        public string? Sexo { get; set; }    
        public string? RG { get; set; }  
        public string? CPF { get; set; } 
        public string? NomeMae { get; set; }     
        public string? SituacaoCadastro { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }
    }
}


