﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_mos_ru.Entities
{
    public class AvailabilityItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Available_elementItem> available_element { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_o { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_z { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_s { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string available_k { get; set; }
    }
}
