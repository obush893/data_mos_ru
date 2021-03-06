﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace data_mos_ru.Entities
{
    [DataContract(Name = "OMK002_2013_1")]
    [Table("OMK002_2013_1", Schema = "data_mos_ru")]
    public class OMK002_2013_1
    {
        //[DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        /*[DataMember]
        public int Number { get; set; }*/
        [DataMember]
        public int global_id { get; set; }
        [DataMember]
        [MaxLength(40)]
        public string Kod { get; set; }
        [DataMember]
        [MaxLength(40)]
        public string Name { get; set; }
        [DataMember]
        [MaxLength(1000)]
        public string Latin_Name { get; set; }
        [DataMember]
        [MaxLength(1000)]
        public string Type { get; set; }
        [DataMember]
        [MaxLength(1000)]
        public string Kod_okato { get; set; }
        ///*[DataMember]
        //public OMK002_2013_1_Cell Cells { get; set; }*/
    }
    /*public class OMK002_2013_1_Cell
    {
        [DataMember]
        public int global_id { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string Kod { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string Name { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string Latin_Name { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string Type { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string Kod_okato { get; set; }
        
    }*/


}