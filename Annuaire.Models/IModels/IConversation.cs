using Annuaire.Models.Bases;
using System.Collections.Generic;

namespace Annuaire.Models.IModels
{
    public interface IConversation : IModel
    {
        public IEnumerable<IUser> Participants { get; set; }
        public string Titre { get; set; }
        public IService ServiceConcerne { get; set; }
        public IPrestation PrestationConcerne { get; set; }
        public IEnumerable<IMessage> Messages();
    }
}