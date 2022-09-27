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
    [Table("Cargo")]
    public class Cargo : ModelPersonalizado
    {
        public Cargo()
        {

        }

        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }


    }
}
