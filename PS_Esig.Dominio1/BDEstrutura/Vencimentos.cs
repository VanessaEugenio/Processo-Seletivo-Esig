using PS_Esig.Dominio.MConexaoBD;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PS_Esig.Dominio.BDEstrutura
{
    [Table ("Vencimentos")]
    public class Vencimentos : ModelPersonalizado
    {
        public Vencimentos()
        {

        }
        public int ID { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public string Tipo { get; set; }
        public string Forma_Incidencia { get; set; }

    }
}
