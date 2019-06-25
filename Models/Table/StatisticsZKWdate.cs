using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_WebApi.Models
{
    [Table("StatisticsZKWdate")] // 需映射的数据库表名称
    public class StatisticsZKWdate
    {
        [Key] // 主键
        public string report_level { get; set; }

        public string device_classify_code { get; set; }

        public string device_classify { get; set; }

        public string bureau_name { get; set; }

        public string bureau_code { get; set; }

        public string county_code { get; set; }

        public string county_name { get; set; }

        public int device_total { get; set; }

        public int sfzbm_connums { get; set; }

        public int sfzbm_diffnums { get; set; }

        public float sfzbm_conrate { get; set; }

        public int wszd_connums { get; set; }

        public int wszd_diffnums { get; set; }

        public float wszd_conrate { get; set; }

        public string updatetime { get; set; }

        public int sort { get; set; }
    }
}
