//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication_MasterDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.BookingEntries = new HashSet<BookingEntry>();
        }
    
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Picture { get; set; }
        public Nullable<bool> MaritalStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [ForeignKey("ClientId")]
        public virtual ICollection<BookingEntry> BookingEntries { get; set; }
    }
}
