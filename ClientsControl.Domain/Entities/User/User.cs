using ClientsControl.Domain.Entities.User.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsControl.Domain.Entities.User
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Sector Setor { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Admin { get; set; }
    }
}
