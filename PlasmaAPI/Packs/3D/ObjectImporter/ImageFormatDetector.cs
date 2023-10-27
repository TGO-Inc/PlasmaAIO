using Sirenix.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.Packs.MeshUtil
{
    internal enum ImageFormat
    {
        Unknown,
        BMP,
        JPG,
        PNG,
        GIF,
        TGA
    }

    internal static class ImageFormatDetector
    {
        public static ImageFormat DetectImageFormat(Stream stream)
        {
            byte[] buffer = new byte[8];
            var originalPosition = stream.Position;
            try
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead < buffer.Length)
                {
                    return ImageFormat.Unknown;
                }
                return DetectImageFormat(buffer);
            }
            finally
            {
                stream.Position = originalPosition;
            }
        }
        public static ImageFormat DetectImageFormat(byte[] buffer)
        {
            if (buffer[0] == 0x42 && buffer[1] == 0x4D)
            {
                return ImageFormat.BMP;
            }
            else if (buffer[0] == 0xFF && buffer[1] == 0xD8)
            {
                return ImageFormat.JPG;
            }
            else if (buffer[0] == 0x89 && buffer[1] == 0x50 &&
                        buffer[2] == 0x4E && buffer[3] == 0x47 &&
                        buffer[4] == 0x0D && buffer[5] == 0x0A &&
                        buffer[6] == 0x1A && buffer[7] == 0x0A)
            {
                return ImageFormat.PNG;
            }
            else if (buffer[0] == 0x47 && buffer[1] == 0x49 &&
                        buffer[2] == 0x46)
            {
                return ImageFormat.GIF;
            }
            else if (buffer[0] == 0x00 && buffer[1] == 0x00 &&
                        buffer[2] == 0x0A && buffer[3] == 0x00 && buffer[4] == 0x00 &&
                        buffer[5] == 0x00 && buffer[6] == 0x00 && buffer[7] == 0x00)
            {
                return ImageFormat.TGA;
            }
            else
            {
                return ImageFormat.Unknown;
            }
        }
    }
}
