﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_mos_ru.Entityes
{
    [Table("UPRs", Schema = "dom_mos_ru")]
    public class UPR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public string Url { get; set; }
        public string Section { get; set; }
    }
}