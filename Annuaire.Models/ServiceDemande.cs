using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models
{
    public class ServiceDemande : IServiceDemande
    {
        public ServiceDemande() { }
        public ServiceDemande(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public bool EstSignaler { get; set; }

        public ICategorie Categorie { get; set; }
        public string Pourquoi { get; set; }
        public string Prix { get; set; }

        public IPersonne Auteur { get; set; }
        public IRegion Ville { get; set; }
        public string Adresse { get; set; }
        public string QuandCombien { get; set; }
        
    }
}
