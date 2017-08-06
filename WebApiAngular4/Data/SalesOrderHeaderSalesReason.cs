﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular4.Data
{
    [Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
    public partial class SalesOrderHeaderSalesReason
    {
        [Column("SalesOrderID")]
        public int SalesOrderId { get; set; }
        [Column("SalesReasonID")]
        public int SalesReasonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("SalesOrderId")]
        [InverseProperty("SalesOrderHeaderSalesReason")]
        public virtual SalesOrderHeader SalesOrder { get; set; }
        [ForeignKey("SalesReasonId")]
        [InverseProperty("SalesOrderHeaderSalesReason")]
        public virtual SalesReason SalesReason { get; set; }
    }
}
