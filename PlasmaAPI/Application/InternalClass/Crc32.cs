using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaAPI.Application.InternalClass
{
    internal class Crc32 : HashAlgorithm
    {
        private const uint DefaultPolynomial = 0xedb88320u;
        private const uint DefaultSeed = 0xffffffffu;

        private uint _hash;
        private readonly uint _seed;
        private readonly uint[] _table;
        private static uint[] _defaultTable;

        public Crc32()
            : this(DefaultPolynomial, DefaultSeed)
        {
        }

        public Crc32(uint polynomial, uint seed)
        {
            _table = InitializeTable(polynomial);
            _seed = _hash = seed;
        }

        public override void Initialize()
        {
            _hash = _seed;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _hash = CalculateHash(_table, _hash, array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            var hashBuffer = UInt32ToBigEndianBytes(~_hash);
            HashValue = hashBuffer;
            return hashBuffer;
        }

        public override int HashSize => 32;
        public static byte[] ComputeHash(Stream stream, uint seed)
        {
            var crc32 = new Crc32(DefaultPolynomial, seed);
            return crc32.ComputeHash(stream);
        }

        public static byte[] ComputeHash(byte[] buffer, uint seed)
        {
            var crc32 = new Crc32(DefaultPolynomial, seed);
            return crc32.ComputeHash(buffer);
        }

        public static byte[] ComputeHash(string input, uint seed)
        {
            var crc32 = new Crc32(DefaultPolynomial, seed);
            return crc32.ComputeHash(Encoding.UTF8.GetBytes(input));
        }

        private static uint[] InitializeTable(uint polynomial)
        {
            if (polynomial == DefaultPolynomial && _defaultTable != null)
            {
                return _defaultTable;
            }

            var table = new uint[256];
            for (uint i = 0; i < 256; i++)
            {
                var entry = i;
                for (var j = 0; j < 8; j++)
                {
                    if ((entry & 1) == 1)
                    {
                        entry = (entry >> 1) ^ polynomial;
                    }
                    else
                    {
                        entry >>= 1;
                    }
                }
                table[i] = entry;
            }

            if (polynomial == DefaultPolynomial)
            {
                _defaultTable = table;
            }

            return table;
        }

        private static uint CalculateHash(uint[] table, uint seed, byte[] buffer, int start, int size)
        {
            var crc = seed;
            for (var i = start; i < size; i++)
            {
                unchecked
                {
                    crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
                }
            }
            return crc;
        }

        private static byte[] UInt32ToBigEndianBytes(uint x)
        {
            return new[] {
            (byte)((x >> 24) & 0xff),
            (byte)((x >> 16) & 0xff),
            (byte)((x >> 8) & 0xff),
            (byte)(x & 0xff)
        };
        }
    }
}
