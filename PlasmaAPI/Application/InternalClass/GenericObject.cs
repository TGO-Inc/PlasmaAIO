extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using System;

namespace Plasma.Application.InternalClass
{
    internal class GenericObject<T>
    {
        public T Value { get; set; }
        public GenericObject(T val)
        {
            Value = val;
        }
        public static implicit operator Type(GenericObject<T> dynam)
        {
            return (Type)(object)dynam.Value;
        }

        public static implicit operator SubComponentHandler(GenericObject<T> dynam)
        {
            return (SubComponentHandler)(object)dynam.Value;
        }

        public static implicit operator SerializedComponent(GenericObject<T> dynam)
        {
            return (SerializedComponent)(object)dynam.Value;
        }

        public static implicit operator GenericObject<T>(T someValue)
        {
            return new GenericObject<T>(someValue);
        }
    }
}
