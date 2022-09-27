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
    [Table ("Salarios")]
    public class Salarios : ModelPersonalizado
    {
        public Salarios()
        {

        }
        [Key]
        public int Pessoa_ID { get; set; }
        public string Nome { get; set; }
        public double Salario_Bruto { get; set; }
        public double Descontos { get; set; }
        public double Salario_Liquido { get; set; }

    }
}
