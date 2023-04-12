using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaAPI.Application.InternalClass
{
    public class ByteArrayEqualityComparer : IEqualityComparer<byte[]>
    {
        public bool Equals(byte[] x, byte[] y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return x.SequenceEqual(y);
        }

        public int GetHashCode(byte[] obj)
        {
            if (obj == null)
            {
                return 0;
            }

            int hash = 17;
            foreach (byte b in obj)
            {
                hash = hash * 23 + b.GetHashCode();
            }
            return hash;
        }
    }
}
