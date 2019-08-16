﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace data_mos_ru.Entities
{
    [Table("Data_1641_5988_ResponsiblePersonsItem", Schema = "data_mos_ru")]
    [DataContract(Name = "ResponsiblePersonsItem")]
    public class Data_1641_5988_ResponsiblePersonsItem
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FIO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string TypePosition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string NamePosition { get; set; }
    }
    [Table("Data_1641_5988_FactAddressItem", Schema = "data_mos_ru")]
    [DataContract(Name = "FactAddressItem")]
    public class Data_1641_5988_FactAddressItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FactAddress { get; set; }
    }
    [Table("Data_1641_5988_AdditionalOKVEDItem", Schema = "data_mos_ru")]
    [DataContract(Name = "AdditionalOKVEDItem")]
    public class Data_1641_5988_AdditionalOKVEDItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string AdditionalOKVED { get; set; }
    }
    [Table("Data_1641_5988_PersonalAccountsItem", Schema = "data_mos_ru")]
    [DataContract(Name = "PersonalAccountsItem")]
    public class Data_1641_5988_PersonalAccountsItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OpenDate { get; set; }
    }
    [Table("Data_1641_5988_BankingDetailsItem", Schema = "data_mos_ru")]
    [DataContract(Name = "BankingDetailsItem")]
    public class Data_1641_5988_BankingDetailsItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string SettlementAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string BIK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string NameBank { get; set; }
    }

    [Table("data_1641_5988", Schema = "data_mos_ru")]
    [DataContract(Name = "data_1641_5988")]
    public class Data_1641_5988
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public Guid data_1641_5988_ID { get; set; }
        [DataMember]
        public string ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int global_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Data_1641_5988_ResponsiblePersonsItem> ResponsiblePersons { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Data_1641_5988_FactAddressItem> FactAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OrgType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string DateBegin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string DateEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string INN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string KPP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string INN_KPP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string ShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OGRN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Territory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<string> AdmArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<string> District { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<string> PostalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string LegalAddressMGK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string DepartmentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string LegalAddressEGRUL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Verification { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKOPF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKATO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKPO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UNK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKVED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OGS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKTMO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKFS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OKOGU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Data_1641_5988_AdditionalOKVEDItem> AdditionalOKVED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Data_1641_5988_PersonalAccountsItem> PersonalAccounts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Data_1641_5988_BankingDetailsItem> BankingDetails { get; set; }
    }
}


