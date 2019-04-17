using System;
using System.Collections.Generic;
namespace Google.Protobuf
{
    /// <summary>
    /// Immutable array of bytes.
    /// </summary>
    public interface IStreamPoolItem
    {
        byte[] GetBuffer();
        int GetLength();
    }
    public interface IStreamPool
    {
        IStreamPoolItem Get(byte[] bytes, int offset, int count);
        void Release(IStreamPoolItem item);
    }
    public interface IObjectPool<T>  where T : IMessage<T>
    {
        T Get();
        void Release(T t);
    }
    public interface IPoolItem
    {
        void Clear();
    }
}
