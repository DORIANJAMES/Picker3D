using System;
using Unity.Mathematics;

namespace Keys
{
    [Serializable]
    public struct HorizontalInputParams
    {
        public float2 ClampValues;
        public float HorizontalValue;
    }
}