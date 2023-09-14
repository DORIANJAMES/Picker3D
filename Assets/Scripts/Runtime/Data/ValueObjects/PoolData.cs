using System;

namespace Runtime.Data.ValueObjects
{
   [Serializable]
   public struct PoolData
   {
      // Negatif değer kullanmayacağımız için int yerine byte kullanıyoruz. 0-255 aralığı bizim yeterli olacaktır.
      public byte RequiredObjectCount;
   }
}
