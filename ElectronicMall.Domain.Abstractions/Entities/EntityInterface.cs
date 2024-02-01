/*
Desc:常用的实体功能接口
Author:Joker
CreatedDate:24-02-01
*/

using System.ComponentModel.DataAnnotations;

namespace ElectronicMall.Domain.Abstractions.Entities
{
    /// <summary>
    /// 软删除接口
    /// </summary>
    public interface ILogicallyDeletable
    {
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
        bool IsDeleted { get; set; } 
    }

    /// <summary>
    /// 乐观并发接口
    /// </summary>
    public interface IOptimisticConcurrencySupported
    {
        /// <summary>
        /// 行版本 乐观并发锁
        /// </summary>
        [ConcurrencyCheck]
        string ConcurrencyStamp { get; set; }   
    }
}
