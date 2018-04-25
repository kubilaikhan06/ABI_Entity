using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjABI
{
    /// <summary>
    /// classe des contacts: permet de mémoriser les informations concernant un contact
    /// comporte des membres propriétés et le nombre de contacts
    /// (donnée partagée par toutes les instances---->static)
    /// </summary>
    public class MContact
    {
        /// <summary>
        /// nombre de contacts de la classe
        /// </summary>
        public static Int32 nbContacts;

        /// <summary>
        /// collection des documents
        /// </summary>
        private List<MDocument> documents = new List<MDocument>();

        private Int32 idContact;
        private String nomContact;
        private String prenomContact;
        private String telContact;
        private String emailContact;
        private String fonctionContact;
        private Int32 durée;

        public int IdContact { get => idContact; set => idContact = value; }
        public string NomContact { get => nomContact; set => nomContact = value; }
        public string PrenomContact { get => prenomContact; set => prenomContact = value; }
        public string TelContact { get => telContact; set => telContact = value; }
        public string FonctionContact { get => fonctionContact; set => fonctionContact = value; }
        public string EmailContact { get => emailContact; set => emailContact = value; }
        public int Durée { get => durée; set => durée = value; }

        /// <summary>
        /// constructeur par défaut
        /// </summary>
        public MContact() { }
        /// <summary>
        /// constructeur d'initilisation contact
        /// </summary>
        /// <param name="ic"></param>
        /// <param name="nc"></param>
        /// <param name="pc"></param>
        /// <param name="tc"></param>
        /// <param name="fc"></param>
        public MContact(int ic, string nc, string pc, string tc,string emc, string fc, int du)
        {
            this.IdContact = ic;
            this.NomContact = nc;
            this.PrenomContact = pc;
            this.TelContact = tc;
            this.EmailContact = emc;
            this.FonctionContact = fc;
            this.Durée = du;
        }
        
        //méthodes de mise à jour de la collection document

        public void AddDocument(MDocument newDocument) { }

        public void RetreiveDocument(int idDocument) { }

        public void UpdateDocument(MDocument newDocument) { }

        public void RemoveDocument(MDocument oldDocument) { }

        public void RemovAllDocument() { }
    }
}
