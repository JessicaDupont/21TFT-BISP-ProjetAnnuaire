using Annuaire.DAL.Repositories;
using Annuaire.DAL.Repositories.Bases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire.Tests.DAL
{
    [TestClass]
    public class ServiceProposeRepositoryTests
    {
        [TestMethod]
        public void ReadNotNull()
        {
            IServiceProposesRepository repo = new ServiceProposesRepository();
            var result = repo.Read();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void SearchCategoryNotNull()
        {
            IServiceProposesRepository repo = new ServiceProposesRepository();
            var result = repo.Search("CategorieId", 3);
            Assert.IsNotNull(result);
        }
    }
}
