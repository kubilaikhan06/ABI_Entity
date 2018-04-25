using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjABI
{
    /// <summary>
    /// classe des clients: permet de mémoriser les informations concernant un client
    /// comporte des membres propriétés et le nombre de clients
    /// (donnée partagée par toutes les instances---->static)
    /// </summary>
    public class MClient
    {
        /// <summary>
        /// nb de clients de la classe
        /// </summary>
        public static Int32 nbClients;
        /// <summary>
        /// collection des contacts
        /// </summary>
        private  List<MContact>  contacts= new List<MContact> ();

        private Int32 idClient;
        private String raisonSociale;
        private String typeSociete;
        private String activite;
        private Int32 idActiv;
        private String adresse;
        private String telephoneClient;
        private String emailClient;
        private String nature;
        private decimal chAf;
        private Int32 effectif;
        private String commentComm;

        public int IdClient { get => idClient; set => idClient = value; }
        public string RaisonSociale { get => raisonSociale; set => raisonSociale = value.Trim().ToUpper(); }
        public string TypeSociete { get => typeSociete; set => typeSociete = value; }
        public string Activite { get => activite; set => activite = value; }
        public int IdActiv { get => idActiv; set => idActiv = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string TelephoneClient { get => telephoneClient; set => telephoneClient = value; }
        public string EmailClient { get => emailClient; set => emailClient = value; }
        public string Nature { get => nature; set => nature = value; }
        public decimal ChAf { get => chAf; set => chAf = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        public string CommentComm { get => commentComm; set => commentComm = value; }        
       

        /// <summary>
        /// constructeur par défaut
        /// </summary>
        public MClient() { }
        /// <summary>
        /// constructeur d'initialisation client
        /// </summary>
        /// <param name="idC"></param>
        /// <param name="rS"></param>
        /// <param name="ty"></param>
        /// <param name="ac"></param>
        /// <param name="ad"></param>
        /// <param name="tel"></param>
        /// <param name="na"></param>
        /// <param name="ca"></param>
        /// <param name="ef"></param>
        /// <param name="co"></param>
        public MClient(int idC, string rS, string ty, string ac, int nuA, string ad, string tel, string em, string na, decimal ca, int ef, string co)
        {
            this.IdClient = idC;
            this.RaisonSociale = rS;
            this.TypeSociete = ty;
            this.Activite = ac;
            this.IdActiv = nuA;
            this.Adresse = ad;
            this.TelephoneClient = tel;
            this.EmailClient = em;
            this.Nature = na;
            this.ChAf = ca;
            this.Effectif = ef;
            this.CommentComm = co;
        }

        public MClient(MClient c)
        {
            this.IdClient = c.IdClient;
            this.RaisonSociale = c.RaisonSociale;
            this.TypeSociete = c.TypeSociete;
            this.Activite = c.Activite;
            this.IdActiv = c.IdActiv;
            this.Adresse = c.Adresse;
            this.TelephoneClient = c.TelephoneClient;
            this.EmailClient = c.EmailClient;
            this.Nature = c.Nature;
            this.ChAf = c.ChAf;
            this.Effectif = c.Effectif;
            this.CommentComm = c.CommentComm;
        }
        
        /// <summary>
        /// calcul le chiffre d'affaire par personne
        /// </summary>
        /// <returns></returns>
        public decimal RatioChAf()
        {
            return this.ChAf /Convert.ToDecimal( this.Effectif);
        }

        //méthodes de mise à jour de la collection contact

        public void AddContact (MContact newContact) { }

        public void RetreiveContact (int idContact) { }

        public void UpdateContact (MContact newContact) { }

        public void RemoveContact (MContact oldContact) { }

        public void RemovaAllContact() { }
    }
}
