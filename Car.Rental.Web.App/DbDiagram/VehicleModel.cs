//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car.Rental.Web.App.DbDiagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleModel()
        {
            this.Vehicle = new HashSet<Vehicle>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid VehicleBrandId { get; set; }
        public string Name { get; set; }
        public int MaxPassengers { get; set; }
        public bool BigLuggage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
    }
}
