//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiyoskWall
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.PoonehReservations = new HashSet<PoonehReservation>();
            this.ExtraTimes = new HashSet<ExtraTime>();
            this.Person_Restaurant = new HashSet<Person_Restaurant>();
        }
    
        public int Id { get; set; }
        public Nullable<long> Rc_Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Sex_Id_Fk { get; set; }
        public string PersonelNo { get; set; }
        public string ShNo { get; set; }
        public string NationalCode { get; set; }
        public Nullable<int> Status_Id_Fk { get; set; }
        public string Note { get; set; }
        public Nullable<int> EmploymentType_Id_Fk { get; set; }
        public string ContractStartDate { get; set; }
        public string ContractEndDate { get; set; }
        public Nullable<int> Company_Id_Fk { get; set; }
        public Nullable<int> Unit_Id_Fk { get; set; }
        public Nullable<int> Contractor_Id_Fk { get; set; }
        public Nullable<int> Card_Id_Fk { get; set; }
        public byte[] PersonImage { get; set; }
        public Nullable<bool> ImageAccept { get; set; }
        public Nullable<int> WorkSheet_Id_FK { get; set; }
        public Nullable<System.DateTime> PoonehArchived { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual WorkSheet WorkSheet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoonehReservation> PoonehReservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtraTime> ExtraTimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person_Restaurant> Person_Restaurant { get; set; }
    }
}
