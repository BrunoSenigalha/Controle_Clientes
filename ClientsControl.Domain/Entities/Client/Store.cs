using ClientsControl.Domain.Entities.Client.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClientsControl.Domain.Entities.Client
{
    public class Store : Entity  
    {
        public BusinessModel Modelo { get; set; }
        public string NomeLoja { get; set; }
        public string ModeloTotem { get; set; }
        public bool PDVAdicional { get; set; }
        public bool TefContratado { get; set; }
        public string Adquirente { get; set; }
        public bool GatewayCPFCNPJ { get; set; }
        public bool PublicacaoAPP { get; set; }
        public bool TravaAcesso { get; set; }
        public bool TravaCervejeira { get; set; }
        public bool BloqueioMaior { get; set; }
        public bool Facial { get; set; }
        public string ImportacaoDados { get; set; }
        public DateTime PrazoInauguracao { get; set; }
        public Address Endereco { get; set; }
        public DateTime CriadoEm { get; set; }
        public Store()
        {
            CriadoEm = DateTime.Now;
            
        }
    }
}
