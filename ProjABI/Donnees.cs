using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjABI
{
    /// <summary>
    /// classe générale des données à gérer
    /// ---------
    /// classe qui regroupe les données
    /// de l'application de gestion des clients et des contacts
    /// dans une collection d'objets définie en static (=non instanciable)
    /// </summary>
    public static class Donnees
    {
        /// <summary>
        /// collection Entity d'objets Client
        /// </summary>
        //public static ArrayList ArrayClient = new ArrayList();

        public static ProjetABIEntities DbClient = new ProjetABIEntities();

        /// <summary>
        /// collection Entity d'objets Contact
        /// </summary>
        //public static ProjetABIEntities DbContact = new ProjetABIEntities();

    }
}
