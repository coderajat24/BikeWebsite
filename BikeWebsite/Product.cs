//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Foolproof;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }

        [Required]
        public int ProductID { get; set; }

        [Required]
        [Remote("doesNameExist", "BikeManager", HttpMethod = "POST", ErrorMessage = "Name already in use")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be longer than 3 characters and less than 50 characters")]
        public string Name { get; set; }

        [Required]
        [Remote("doesProdNumExist", "BikeManager", HttpMethod = "POST", ErrorMessage = "Product Number already in use")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "ProductNumber must be longer than 3 characters and less than 25 characters")]
        public string ProductNumber { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Color must be longer than 3 characters and less than 15 characters")]
        public string Color { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue, ErrorMessage = "Standard Cost cannot be negative")]
        public decimal StandardCost { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue, ErrorMessage = "List Price cannot be negative")]
        [GreaterThan("StandardCost", ErrorMessage = "ListPrice must be greater than StandardCost")]
        public decimal ListPrice { get; set; }

        [StringLength(5, MinimumLength = 1, ErrorMessage = "Size must be longer than 1 character and less than 5 characters")]
        public string Size { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Weight cannot be negative")]
        public Nullable<decimal> Weight { get; set; }

        [Required]
        public Nullable<int> ProductCategoryID { get; set; }

        [Required]
        public Nullable<int> ProductModelID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime SellStartDate { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> SellEndDate { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DiscontinuedDate { get; set; }

        [ScaffoldColumn(false)]
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public System.Guid rowguid { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime ModifiedDate { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
