//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjABI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Contact = new HashSet<Contact>();
        }
    
        public int IdentifiantClient { get; set; }
        public string RaisonSociale { get; set; }
        public string Type { get; set; }
        public string Activite { get; set; }
        public int NumeroActivite { get; set; }
        public string Adresse { get; set; }
        public string TelephoneClient { get; set; }
        public string EmailClient { get; set; }
        public string Nature { get; set; }
        public Nullable<decimal> ChiffreAffaire { get; set; }
        public Nullable<int> Effectif { get; set; }
        public string Commentaires { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
