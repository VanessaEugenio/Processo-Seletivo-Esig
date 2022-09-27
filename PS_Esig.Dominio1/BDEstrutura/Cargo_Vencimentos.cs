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
    [Table ("Cargo_Vencimentos")]
    public class Cargo_Vencimentos : ModelPersonalizado
    {
        public Cargo_Vencimentos()
        {

        }

        [Key]
        public int ID { get; set; }
        public int Cargo_ID { get; set; }
        public int Vencimento_ID { get; set; }
    }
}
