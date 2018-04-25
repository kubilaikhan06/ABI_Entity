using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjABI
{
    /// <summary>
    /// classe des méthodes EstEntier(contrôle si la chaîne reçue est un entier) et EstUneChaine(contrôle si la chaîne reçue est chaîne de caractères).
    /// </summary>
    public class Outils
    {
        /// <summary>
        /// fonction générique de controle qu'une chaine reçue  
        /// pourra se convertir en Int32
        /// </summary>
        /// <param name="s">la string à controler</param>
        /// <returns>booléen: true=OK, false= erreur</returns>
        public static Boolean EstEntier(string s)
        {
            //vérifier que la chaine reçue représente bien un entier valide:
            //- uniquement des chiffres
            //- Pas vide
            //- Pas plus de 9 chiffres (capacité max du type Int32)

            Char c;
            Boolean code = true;

            // test longuer chaine recue
            if (s.Length < 15 && s.Length > 0)
            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i]; //extrait le i° caractère
                    if (!(Char.IsDigit(c))) //si ce n'est pas un chiffre
                    {
                        code = false; //erreur détectée
                    }

                }
            }
            else //erreur de longueur de chaîne
            {
                code = false; //erreur détectée
            }
            return code;
        }
        /// <summary>
        /// fonction générique de contrôle qu'une chaîne reçue 
        /// est bien une suite de caractères
        /// </summary>
        /// <param name="s">la string à controler</param>
        /// <returns>booléen: true=OK, false= erreur</returns>
        public static Boolean EstUneChaine(String s)
        {
            Char c;
            Boolean code = true;

            for (int i = 0; i < s.Length; i++)
            {
                c = s[i];
                if (!(Char.IsLetter(c))) // si ce n'est pas une chaîne de caractères
                {
                    code = false;
                }
            }
            return code;
        }

    
    }
}
