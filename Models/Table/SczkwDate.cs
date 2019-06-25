using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NetCore_WebApi.Models
{
    [Table("SCZKWdate")] // 需映射的数据库表名称
    public class SczkwDate
    {
        [Key] // 主键
        public int id { get; set; }
        public string province_code { get; set; }
        public string bureau_code { get; set; }
        public string bureau_name { get; set; }
        public string county_id { get; set; }
        public string county_code { get; set; }
        public string county { get; set; }
        public string device_id { get; set; }
        public string device_code { get; set; }
        public string device_classify { get; set; }
        public string device_name { get; set; }
        public string classify_code { get; set; }
        public string classify_full_name { get; set; }
        public string device_model { get; set; }
        public string full_name { get; set; }
        public string full_path { get; set; }
        public string is_capital_assets { get; set; }
        public string asset_state { get; set; }
        public string finance_asset_state { get; set; }
        public string proprietor_owner { get; set; }
        public string base_voltage_id { get; set; }
        public string proprietor_company_oname { get; set; }
        public string vendor { get; set; }
        public string leave_factory_date { get; set; }
        public string plant_transfer_date { get; set; }
        public string power_grid_flag { get; set; }
        public DateTime? update_time { get; set; }
    }
}
