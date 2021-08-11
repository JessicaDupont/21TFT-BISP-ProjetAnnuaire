using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models.IModels
{
    public interface IServiceDemande : IService
    {
        public IPersonne Auteur { get; set; }
        public IRegion Ville { get; set; }
        public string Adresse { get; set; }
        public string QuandCombien {get; set;}
    }
}
