using ClientsControl.Domain.Entities.Client.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsControl.Domain.Entities.Client
{
    public class Client : Entity
    {
        public CategoryClient Categoria { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Responsavel { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public ServerModel Servidor { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Address Endereco { get; set; }
        public DateTime CriadoEm { get; set; }

        public Client()
        {
            CriadoEm = DateTime.Now;
        }

    }
}
