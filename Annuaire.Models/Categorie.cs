using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models
{
    public class Categorie : ICategorie
    {
        public Categorie() { }
        public Categorie(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

        public string Nom { get; set; }
        public string Description { get; set; }
        public ICategorie Parent { get; set; }
    }
}
