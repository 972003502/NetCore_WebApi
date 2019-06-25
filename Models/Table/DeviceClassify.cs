using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NetCore_WebApi.Models
{
    [Table("ZKWSBLB")] // 需映射的数据库表名称
    public class DeviceClassify
    {
        public string sys_classify_name { get; set; }

        public string sys_classify_id { get; set; }

        public string device_classify { get; set; }
        [Key] // 主键
        public string device_code { get; set; }

        public int sort { get; set; }
    }
}
