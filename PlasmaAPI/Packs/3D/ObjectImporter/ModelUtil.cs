using Newtonsoft.Json;
using PlasmaAPI.Application.InternalClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.Packs.MeshUtil
{
    public class ModelUtil
    {
        private static readonly byte[] ColladaBytes = Encoding.ASCII.GetBytes("<COLLADA");
        private static readonly byte[] SvgBytes = Encoding.ASCII.GetBytes("<svg");
        private static readonly byte[] XmlBytes = Encoding.ASCII.GetBytes("<?xml");
        private static readonly byte[] VoxBytes = Encoding.ASCII.GetBytes("VOX ");
        private static readonly byte[] SolidBytes = Encoding.ASCII.GetBytes("solid");
        private static readonly byte[] ObjMtlBytes = Encoding.ASCII.GetBytes("mtllib");
        private static readonly byte[] FbxHeaderBytes = Encoding.ASCII.GetBytes("73 76 61");
        private static readonly int MaxHeaderBytes = 8;

        /// <summary>
        /// Attemps to detect the 3D model type as quickly and efficently as possible
        /// </summary>
        /// <param name="stream">3D Model</param>
        /// <returns>3D Model File Type</returns>
        public static MeshType Detect(ResourceStream stream)
        {
            byte[] header = new byte[MaxHeaderBytes];
            uint index = 0;
            bool isComment = false;
            stream.Position = 0;
            while (stream.Position < stream.Length && index < MaxHeaderBytes)
            {
                int b = stream.ReadByte();
                if (b == -1 || MaxHeaderBytes == index)
                {
                    break;
                }

                byte currentByte = (byte)b;

                // Check for comment start
                if (currentByte == '#')
                {
                    isComment = true;
                }

                // Check for new line
                if (currentByte == '\n')
                {
                    isComment = false;
                    if (index > 0)
                    {
                        break;
                    }
                }
                else if (!isComment && !char.IsWhiteSpace((char)currentByte))
                {
                    header[index++] = currentByte;
                }
            }

            ReadOnlySpan<byte> headerSpan = header.AsSpan();

            if (headerSpan.Slice(0, 8).SequenceEqual(ColladaBytes))
                return MeshType.DAE;
            if (headerSpan.Slice(0, 4).SequenceEqual(SvgBytes) || headerSpan.Slice(0, 5).SequenceEqual(XmlBytes) && headerSpan.IndexOf(SvgBytes) != -1)
                return MeshType.SVG;
            if (headerSpan.Slice(0, 4).SequenceEqual(VoxBytes))
                return MeshType.VOX;
            if (headerSpan.Slice(0, 5).SequenceEqual(SolidBytes))
                return MeshType.STL;
            if (headerSpan.Slice(0, 6).SequenceEqual(FbxHeaderBytes))
                return MeshType.FBX;
            if ((header[0] == 'v' || header[0] == 'g' || header[0] == 'o') && header[1] == ' ')
                return MeshType.OBJ;
            if (headerSpan.Slice(0, 6).SequenceEqual(ObjMtlBytes))
                return MeshType.OBJ;

            return MeshType.Unknown;
        }
    }
}
