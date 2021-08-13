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
        public ServiceDemande() 
        {
            DonneesRecuperees = false;
        }
        public ServiceDemande(int id) : this()
        {
            Id = id;
        }

        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }
        public bool EstSignaler { get; set; }

        public ICategorie Categorie { get; set; }
        public string Pourquoi { get; set; }
        public string Prix { get; set; }

        public IPersonne Auteur { get; set; }
        public IRegion Ville { get; set; }
        public string Adresse { get; set; }
        public string QuandCombien { get; set; }

        public override bool Equals(object obj)
        {
            if (typeof(IService).Equals(obj.GetType()))
            {
                return this.Id == ((IService)obj).Id;
            }
            return base.Equals(obj);
        }

    }
}
