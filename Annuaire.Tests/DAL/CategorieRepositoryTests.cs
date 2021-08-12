using Annuaire.DAL.Repositories;
using Annuaire.DAL.Repositories.Bases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.Repositories;

namespace Annuaire.Tests.DAL
{
    [TestClass]
    public class CategorieRepositoryTests
    {
        [TestMethod]
        public void SearchEnfantsNotNull()
        {
            ICategorieRepository repo = new CategorieRepository();
            var result = repo.Search(new Filtre("Enfants", 7));
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void SearchEnfantsCount()
        {
            ICategorieRepository repo = new CategorieRepository();
            var result = repo.Search(new Filtre("Enfants", 7));
            Assert.AreEqual(3, result.Count());
        }
    }
}
