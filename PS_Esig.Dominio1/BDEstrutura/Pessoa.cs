using PS_Esig.Dominio.MConexaoBD;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PS_Esig.Dominio.BDEstrutura
{
    [Table ("Pessoa")]
    public class Pessoa : ModelPersonalizado 
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Enderco { get; set; }
        public string Pais { get; set; }
        public string Usuario { get; set; }
        public string Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public string Cargo_ID { get; set; }

    }
 
}
