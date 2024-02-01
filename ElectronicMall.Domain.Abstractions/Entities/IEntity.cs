/*
Desc:基础实体接口
Author:Joker
CreatedDate:24-02-01
*/

namespace ElectronicMall.Domain.Abstractions.Entities
{
    /// <summary>
    /// 实体接口
    /// </summary>
    public interface IEntity
    {
    }

    /// <summary>
    /// 实体接口
    /// </summary>
    /// <typeparam name="TKey">唯一标识的类型</typeparam>
    public interface IEntity<TKey> : IEntity where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 实体的唯一标识
        /// </summary>
        TKey Id { get; set; }
    }

}
