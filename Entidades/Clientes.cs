using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public double LimiteCredito { get; set; }

        public List<TiposTelefonos> TiposTelefono { get; set; }

    }
}
