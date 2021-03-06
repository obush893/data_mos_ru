﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace data_mos_ru.Entities
{

    [DataContract(Name = "TM")]
    [Table("TM", Schema = "data_mos_ru")]
    public class TM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /*[DataMember]
        public int Number { get; set; }*/
        [DataMember]
        public int global_id { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_CODE { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_NAMEF { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_NAMES { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_TRANS { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_TYPE { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_TE { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_KLADR { get; set; }
        [MaxLength(2000)]
        [DataMember]
        public string TM_STAT { get; set; }
        /*[DataMember]
        public TM_Cell Cells { get; set; }*/
    }
    public class TM_Cell
    {
        public int global_id { get; set; }
        [MaxLength(2000)]
        public string TM_CODE { get; set; }
        [MaxLength(2000)]
        public string TM_NAMEF { get; set; }
        [MaxLength(2000)]
        public string TM_NAMES { get; set; }
        [MaxLength(2000)]
        public string TM_TRANS { get; set; }
        [MaxLength(2000)]
        public string TM_TYPE { get; set; }
        [MaxLength(2000)]
        public string TM_TE { get; set; }
        [MaxLength(2000)]
        public string TM_KLADR { get; set; }
        [MaxLength(2000)]
        public string TM_STAT { get; set; }
    }

    // [DataContract(Name = "TM")]
    public class TM_DB
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public TM_Cell Cells { get; set; }
        [DataMember]
        public int global_id { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_CODE { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_NAMEF { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_NAMES { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_TRANS { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_TYPE { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_TE { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_KLADR { get; set; }
        [DataMember]
        [MaxLength(2000)]
        public string TM_STAT { get; set; }
        /*public Type GetDataContractType(Type type)
        {
            if (typeof(TM).IsAssignableFrom(type))
            {
                return typeof(TM_DB);
            }
            return type;
        }*/
        /*public object GetObjectToSerialize(object obj, Type targetType)
        {
            if (obj is TM)
            {
                TM territory = (TM)obj;
                TM_DB territoryDB = new TM_DB();
                territoryDB.Id = territory.Id;
                //territoryDB.Number = territory.Number;
                territoryDB.global_id = territory.global_id;
                territoryDB.TM_CODE = territory.TM_CODE;
                territoryDB.TM_NAMEF = territory.TM_NAMEF;
                territoryDB.TM_NAMES = territory.TM_NAMES;
                territoryDB.TM_TRANS = territory.TM_TRANS;
                territoryDB.TM_TYPE = territory.TM_TYPE;
                territoryDB.TM_TE = territory.TM_TE;
                territoryDB.TM_KLADR = territory.TM_KLADR;
                territoryDB.TM_STAT = territory.TM_STAT;
                return territoryDB;
            }
            return obj;
        }*/
        /*public Type GetReferencedTypeOnImport(string typeName,
               string typeNamespace, object customData)
        {
            if (
            typeNamespace.Equals("http://schemas.datacontract.org/2004/07/DCSurrogateSample")
            )
            {
                if (typeName.Equals("TM_DB"))
                {
                    return typeof(TM);
                }
            }
            return null;
        }*/
        /*public System.CodeDom.CodeTypeDeclaration ProcessImportedType(
          System.CodeDom.CodeTypeDeclaration typeDeclaration,
          System.CodeDom.CodeCompileUnit compileUnit)
        {
            return typeDeclaration;
        }
        public object GetCustomDataToExport(Type clrType, Type dataContractType)
        {
            return null;
        }

        public object GetCustomDataToExport(System.Reflection.MemberInfo memberInfo, Type dataContractType)
        {
            return null;
        }*/

    }
}

