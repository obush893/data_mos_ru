﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace data_mos_ru.Entityes
{
    [Table("OMK002_2013_1", Schema = "data_mos_ru")]
    public class OMK002_2013_1
    {
        [DataMember]
        [Key]
        public int global_id { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public OMK002_2013_1_Cell Cells { get; set; }
    }
    public class OMK002_2013_1_Cell
    {
        [DataMember]
        public int global_id { get; set; }
        [DataMember]
        [MaxLength(4000)]
        public string Kod { get; set; }
        [DataMember]
        [MaxLength(4000)]
        public string Name { get; set; }
        [DataMember]
        [MaxLength(4000)]
        public string Latin_Name { get; set; }
        [DataMember]
        [MaxLength(4000)]
        public string Type { get; set; }
        [DataMember]
        [MaxLength(4000)]
        public string Kod_okato { get; set; }
        
    }

   
}