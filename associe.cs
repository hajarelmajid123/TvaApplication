//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TvaApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class associe
    {
        public int IdAssocie { get; set; }
        public string NomAssocie { get; set; }
        public string PrenomAssocie { get; set; }
        public string NumCin { get; set; }
        public string NumCarSejour { get; set; }
        public Nullable<System.DateTime> Date_nai { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Fonction { get; set; }
        public Nullable<double> Part { get; set; }
        public Nullable<int> C_IdSociete { get; set; }
    
        public virtual societe societe { get; set; }
    }
}
