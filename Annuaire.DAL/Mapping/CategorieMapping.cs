using Annuaire.Models;
using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Mapping;

namespace Annuaire.DAL.Mapping
{
    public class CategorieMapping : IMapping<DbDataReader, ICategorie>
    {
        public DbDataReader Mapping(ICategorie model)
        {
            throw new NotImplementedException();
        }

        public ICategorie Mapping(DbDataReader data)
        {
            ICategorie result = new Categorie((int)data["Id"]);
            result.Description = data["Description"] == DBNull.Value ? null : (string)data["Description"];
            result.Nom = (string)data["Nom"];
            result.Parent = data["Categorie_Parent"] == DBNull.Value ? null : new Categorie((int)data["Categorie_Parent"]);
            result.DonneesRecuperees = true;
            return result;
        }
    }
}
