using System;
using System.Collections.Generic;
using System.Text;

namespace Sav.ApplicationCore.Entity
{
    public class Documento
    {
        public Documento()
        {

        }
        public int Id { get; set; }
        public string CPF { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Cnpj { get; set; }
    }
}
