using Annuaire.Models.Bases;
using Annuaire.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.Enums;

namespace Annuaire.Models
{
    public class User : IUser
    {
        public int Id { get; set; }

        public DateTime Inscription { get; set; }
        public DateTime Connexion { get; set; }
        public Roles Role { get; set; }
        public ModesConnexion MethodeConnexion { get; set; }
        public string Login { get; set; }
        public string Token { get; set; }
        public string CommentaireMod { get; set; }

        public IPersonne Particulier { get; set; }
        public IPro Professionnel { get; set; }

        public IEnumerable<IConversation> Conversations() 
        { 
            throw new NotImplementedException();
        }
    }
}
