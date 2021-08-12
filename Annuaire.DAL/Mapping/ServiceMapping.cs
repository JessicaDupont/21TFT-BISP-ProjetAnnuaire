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
    public class ServiceMapping : IMapping<DbDataReader, IService>
    {
        public DbDataReader Mapping(IService model)
        {
            throw new NotImplementedException();
        }

        public IService Mapping(DbDataReader data)
        {
            if ((bool)data["EstDemande"])
            {
                IServiceDemande result = new ServiceDemande((int)data["Id"]);
                result.Adresse = data["Adresse"] == DBNull.Value ? null : (string)data["Adresse"];
                result.Auteur = new Personne((int)data["UserId"]);
                result.Categorie = new Categorie((int)data["CategorieId"]);
                result.EstSignaler = (bool)data["Alerte"];
                result.Pourquoi = (string)data["Pourquoi"];
                result.Prix = data["Prix"] == DBNull.Value ? null : (string)data["Prix"];
                result.QuandCombien = data["QuandCombien"] == DBNull.Value ? null : (string)data["QuandCombien"];
                result.Ville = data["RegionId"] == DBNull.Value ? null : new Region((int)data["RegionId"]);
                return result;
            }
            else 
            {
                IServicePropose result = new ServicePropose((int)data["Id"]);
                result.Auteur = new Pro((int)data["UserId"]);
                result.Categorie = new Categorie((int)data["CategorieId"]);
                result.EstSignaler = (bool)data["Alerte"];
                result.Pourquoi = (string)data["Pourquoi"];
                result.Prix = data["Prix"] == DBNull.Value ? null : (string)data["Prix"];
                return result;
            }
        }
    }
}
