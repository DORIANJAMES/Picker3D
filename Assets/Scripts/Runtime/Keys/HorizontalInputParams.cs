using System;
using Unity.Mathematics;

namespace Runtime.Keys
{
    [Serializable]
    public struct HorizontalInputParams
    {
        public float2 ClampValues;
        public float HorizontalValue;
    }
}