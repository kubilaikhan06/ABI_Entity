using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjABI
{
    /// <summary>
    /// classe des documents: permet de mémoriser les informations concernant un document
    /// comporte des membres propriétés et le nombre de documents
    /// (donnée partagée par toutes les instances---->static)
    /// </summary>
    public class MDocument
    {
        /// <summary>
        /// nb de documents de la classe
        /// </summary>
        public static Int32 nbDocuments;

        private Int32 idDoc;
        private String titreDoc;
        private String auteurDoc;
        private DateTime dateDoc;
        private String resumeDoc;

        public int IdDoc { get => idDoc; set => idDoc = value; }
        public string TitreDoc { get => titreDoc; set => titreDoc = value; }
        public string AuteurDoc { get => auteurDoc; set => auteurDoc = value; }
        public DateTime DateDoc { get => dateDoc; set => dateDoc = value; }
        public string ResumeDoc { get => resumeDoc; set => resumeDoc = value; }
    }
}
