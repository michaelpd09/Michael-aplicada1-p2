using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClientesTelefonos
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int TipoId { get; set; }

        public List<ClientesTelefonos> ClientesTelefono { get; set; }
    }
}
