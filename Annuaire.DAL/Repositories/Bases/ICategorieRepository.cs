using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.Repositories;

namespace Annuaire.DAL.Repositories.Bases
{
    public interface ICategorieRepository : 
        IRepositorySearch<ICategorie, int>
    {
    }
}
