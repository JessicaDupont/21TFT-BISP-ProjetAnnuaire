using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Models.IModels
{
    public interface IServicePropose : IService
    {
        public IPro Auteur { get; set; }
    }
}
