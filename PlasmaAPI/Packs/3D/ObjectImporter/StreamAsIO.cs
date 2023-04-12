using Assimp;
using PlasmaAPI.Application.InternalClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaAPI.Packs.MeshUtil
{
    internal class StreamAsIO : IOStream
    {
        private readonly Stream internalStream;
        public StreamAsIO(string name, ResourceStream stream, FileIOMode mode)
            : base(name, mode)
        {
            internalStream = stream;
        }
        public override bool IsValid => internalStream.CanRead;

        public override void Flush()
        {
            internalStream.Flush();
        }

        public override long GetFileSize()
        {
            return internalStream.Length;
        }

        public override long GetPosition()
        {
            return internalStream.Position;
        }

        public override long Read(byte[] dataRead, long count)
        {
            return internalStream.Read(dataRead, 0, (int)count);
        }

        public override ReturnCode Seek(long offset, Origin seekOrigin)
        {
            internalStream.Seek(offset, (SeekOrigin)(int)seekOrigin);
            return ReturnCode.Success;
        }

        public override long Write(byte[] dataToWrite, long count)
        {
            internalStream.Write(dataToWrite, 0, (int)count);
            return count;
        }
        public override void Close()
        {
            internalStream.Position = 0;
        }
    }
}
