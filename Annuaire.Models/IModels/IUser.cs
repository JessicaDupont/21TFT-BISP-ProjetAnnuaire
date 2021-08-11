using Annuaire.Models.Bases;
using System;
using System.Collections.Generic;
using ToolIca.Enums;

namespace Annuaire.Models.IModels
{
    public interface IUser : IModel
    {
        public DateTime Inscription { get; set; }
        public DateTime Connexion { get; set; }
        public Roles Role { get; set; }
        public ModesConnexion MethodeConnexion { get; set; }
        public string Login { get; set; }
        public string Token { get; set; }
        public string CommentaireMod { get; set; }

        public IPersonne Particulier { get; set; }
        public IPro Professionnel { get; set; }
        public IEnumerable<IConversation> Conversations();
        
    }
}
