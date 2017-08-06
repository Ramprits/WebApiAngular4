﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular4.Data
{
    [Table("DemoSalesOrderHeaderSeed", Schema = "Demo")]
    public partial class DemoSalesOrderHeaderSeed
    {
        public DateTime DueDate { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("SalesPersonID")]
        public int SalesPersonId { get; set; }
        [Column("BillToAddressID")]
        public int BillToAddressId { get; set; }
        [Column("ShipToAddressID")]
        public int ShipToAddressId { get; set; }
        [Column("ShipMethodID")]
        public int ShipMethodId { get; set; }
        [Column("LocalID")]
        public int LocalId { get; set; }
    }
}
