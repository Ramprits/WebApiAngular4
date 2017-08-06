﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular4.Data
{
    [Table("ProductModelProductDescriptionCulture", Schema = "Production")]
    public partial class ProductModelProductDescriptionCulture
    {
        [Column("ProductModelID")]
        public int ProductModelId { get; set; }
        [Column("ProductDescriptionID")]
        public int ProductDescriptionId { get; set; }
        [Column("CultureID", TypeName = "nchar(6)")]
        public string CultureId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("CultureId")]
        [InverseProperty("ProductModelProductDescriptionCulture")]
        public virtual Culture Culture { get; set; }
        [ForeignKey("ProductDescriptionId")]
        [InverseProperty("ProductModelProductDescriptionCulture")]
        public virtual ProductDescription ProductDescription { get; set; }
        [ForeignKey("ProductModelId")]
        [InverseProperty("ProductModelProductDescriptionCulture")]
        public virtual ProductModel ProductModel { get; set; }
    }
}
