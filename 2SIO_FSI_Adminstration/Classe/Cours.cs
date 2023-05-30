using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    internal class Cours
    {
        public int idcours { get; set; }
        public string libellecours { get; set; }
        
        public string descriptioncours { get; set; }

        public Cours(int id, string Cours, string description)
        {
            this.idcours = id;
            this.libellecours = Cours;
            this.descriptioncours = description;
        }
    }
}
