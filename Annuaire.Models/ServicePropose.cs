using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models
{
    public class ServicePropose : IServicePropose
    {
        public ServicePropose() 
        {
            DonneesRecuperees = false;
        }
        public ServicePropose(int id) : this()
        {
            Id = id;
        }

        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }

        public ICategorie Categorie { get; set; }
        public string Pourquoi { get; set; }
        public string Prix { get; set; }
        public bool EstSignaler { get; set; }

        public IPro Auteur { get; set; }
    }
}
