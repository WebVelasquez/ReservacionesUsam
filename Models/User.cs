//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarragoWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.LocalReservation = new HashSet<LocalReservation>();
            this.TableReservation = new HashSet<TableReservation>();
        }
    
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Names { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public System.DateTime BornDate { get; set; }
        public string Email { get; set; }
        public string CellphoneNumber { get; set; }
        public short ReservationsNumber { get; set; }
        public short AssistedNumber { get; set; }
        public short FaultsNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalReservation> LocalReservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableReservation> TableReservation { get; set; }
    }
}