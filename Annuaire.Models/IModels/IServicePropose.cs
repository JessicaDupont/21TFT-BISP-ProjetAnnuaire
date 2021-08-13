using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models.IModels
{
    public interface IServicePropose : IService
    {
        //public IPro Auteur { get; set; }
        public IEnumerable<IRegion> Regions { get; set; }

        ////IModel
        public new int Id { get; set; }
        //public new bool DonneesRecuperees { get; set; }

        ////IAlerte
        //public new bool EstSignaler {get; set;}

        ////IService
        //public new ICategorie Categorie { get; set; }
        //public new string Pourquoi { get; set; }
        //public new string Prix { get; set; }

    }
}
