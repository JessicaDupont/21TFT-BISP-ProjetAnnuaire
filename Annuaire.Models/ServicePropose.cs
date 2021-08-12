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
        public ServicePropose() { }
        public ServicePropose(int id)
        {
            Id = id;
        }

        public ICategorie Categorie { get; set; }
        public string Pourquoi { get; set; }
        public string Prix { get; set; }
        public int Id { get; set; }
        public bool EstSignaler { get; set; }

        public IPro Auteur { get; set; }
    }
}
