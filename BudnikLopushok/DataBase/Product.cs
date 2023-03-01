//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudnikLopushok.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductMaterials = new HashSet<ProductMaterial>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Article { get; set; }
        public Nullable<int> MinPriceForAgent { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> ProductTypeId { get; set; }
        public Nullable<int> ManForProduct { get; set; }
        public Nullable<int> WorkshopNumber { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
    }
}