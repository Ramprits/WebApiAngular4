﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngular4.Data
{
    public partial class ErrorLog
    {
        [Column("ErrorLogID")]
        public int ErrorLogId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ErrorTime { get; set; }
        [Required]
        [Column(TypeName = "sysname")]
        public string UserName { get; set; }
        public int ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        [MaxLength(126)]
        public string ErrorProcedure { get; set; }
        public int? ErrorLine { get; set; }
        [Required]
        public string ErrorMessage { get; set; }
    }
}
