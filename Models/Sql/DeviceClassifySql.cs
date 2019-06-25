using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_WebApi.Models.Sql
{
    public class DeviceClassifySql
    {
        public static string GetAllData = "SELECT * FROM ZKWSBLB";

        public static string GetDataById(string FieldName, string Id)
        {
            return $"SELECT * FROM ZKWSBLB WHERE {FieldName} = {Id}";
        }
    }
}
