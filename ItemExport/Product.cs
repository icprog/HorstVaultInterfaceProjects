//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItemExport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Files = new HashSet<File>();
            this.Operations = new HashSet<Operation>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductProducts = new HashSet<ProductProduct>();
            this.ProductProducts1 = new HashSet<ProductProduct>();
        }
    
        public int ID { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ParentPartNumber { get; set; }
        public string CategoryName { get; set; }
        public double Thickness { get; set; }
        public string StructuralCode { get; set; }
        public string PlantID { get; set; }
        public bool IsStock { get; set; }
        public bool RequiresPDF { get; set; }
        public string Comment { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string State { get; set; }
        public string Keywords { get; set; }
        public string Notes { get; set; }
        public string Revision { get; set; }
        public int MaterialID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files { get; set; }
        public virtual Material Material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProduct> ProductProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProduct> ProductProducts1 { get; set; }
    }
}