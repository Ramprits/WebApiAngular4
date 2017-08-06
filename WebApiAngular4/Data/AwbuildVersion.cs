﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular4.Data
{
    [Table("AWBuildVersion")]
    public partial class AwbuildVersion
    {
        [Column("SystemInformationID")]
        public byte SystemInformationId { get; set; }
        [Required]
        [Column("Database Version")]
        [MaxLength(25)]
        public string DatabaseVersion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime VersionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
