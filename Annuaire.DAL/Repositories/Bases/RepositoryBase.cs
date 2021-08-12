﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Annuaire.DAL.Repositories.Bases
{
    public abstract class RepositoryBase
    {
        private string sourceDB = "Data Source=FORMAVDI1307\\TFTIC;" +
            "Initial Catalog=Annuaire;" +
            "Integrated Security=True;" +
            "Connect Timeout=60;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";
        protected readonly Connexion connect;

        public RepositoryBase()
        {
            connect = new Connexion(SqlClientFactory.Instance, sourceDB);
        }
    }
}
