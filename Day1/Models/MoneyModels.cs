﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Day1.Models
{
    public class Money
    {
        [DisplayName("序號")]
        public string id { get; set; }

        [DisplayName("類別")]
        public string categorydesc {
            get
            {
                return (this.category == 0 ? "收入" :
                        this.category == 1 ? "支出" : "error");      
            }
        }
        
        public int category { get; set; }
        [DisplayName("日期")]
        public DateTime date { get; set; }
        [DisplayName("金額")]
        public decimal amount { get; set; }
        [DisplayName("備註")]
        public string remark { get; set; }
    }

    //public class MoneyViewModel
    //{
    //    public IEnumerable<Money> MoneyList { get; set; }    
    //}
}