//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinePM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Genre { get; set; }
        public string DNI { get; set; }
        public string Phone { get; set; }
        public System.DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public virtual genres genres { get; set; }
    }
}
