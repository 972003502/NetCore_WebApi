using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCore_WebApi.Models
{
    /// <summary>  
    /// 数据库上下文  
    /// </summary>  
    public class ZkwDataContext : DbContext
    {
        public ZkwDataContext(DbContextOptions<ZkwDataContext> options)
            : base(options)
        {
        }

        ////配置实体类型 注：若已在Model中进行特性的配置此处可省略
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Sczkwdate>(entity =>
        //    {
        //        entity.ToTable("SCZKWdate");  // 设置数据库映射表
        //        entity.HasKey(obj => obj.Id);  // 设置主键
        //    });
        //}

        public DbSet<DeviceClassify> DeviceClassify { get; set; }
        public DbSet<SczkwDate> SczkwDate { get; set; }
    }
}
