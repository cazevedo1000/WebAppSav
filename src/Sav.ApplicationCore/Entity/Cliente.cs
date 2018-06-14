using System;
using System.Collections.Generic;
using System.Text;

namespace Sav.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string DocumentoId { get; set; }

    }
}
