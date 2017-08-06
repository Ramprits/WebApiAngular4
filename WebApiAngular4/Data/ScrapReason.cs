﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular4.Data
{
    [Table("ScrapReason", Schema = "Production")]
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            WorkOrder = new HashSet<WorkOrder>();
        }

        [Column("ScrapReasonID")]
        public short ScrapReasonId { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("ScrapReason")]
        public virtual ICollection<WorkOrder> WorkOrder { get; set; }
    }
}
