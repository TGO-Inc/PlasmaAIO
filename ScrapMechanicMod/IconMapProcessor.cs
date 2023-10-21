using StbImageSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;

namespace Plasma.Mods.ScrapMechanicMod
{
    public static class IconMapProcessor
    {
        public class IconInfo
        {
            public string UUID { get; set; }
            public ImageResult Image { get; set; }
        }

        public static Dictionary<string, IconInfo> ExtractIconData(string parentDir)
        {
            var iconDataList = new Dictionary<string, IconInfo>();

            // Locate all IconMap*.xml files
            var iconMapXmlFiles = Directory.GetFiles(parentDir, "IconMap*.xml", SearchOption.AllDirectories)
                                           /*.Where(path => path.Contains("/Gui/"))
                                           .ToList()*/;

            foreach (var xmlPath in iconMapXmlFiles)
            {
                var xmlContent = XDocument.Load(xmlPath);
                var pngPath = Path.ChangeExtension(xmlPath, ".png");

                var fullImage = ImageResult.FromStream(File.OpenRead(pngPath), ColorComponents.RedGreenBlueAlpha);

                foreach (var element in xmlContent.Root.Element("Resource").Element("Group").Elements("Index"))
                {
                    string uuid = element.Attribute("name").Value;
                    if (string.IsNullOrWhiteSpace(uuid)
                        || uuid.ToLower().Equals("empty")
                        | iconDataList.ContainsKey(uuid.ToUpperInvariant()
                        ))
                        continue;

                    var frameElement = element.Element("Frame");
                    var pointValue = frameElement.Attribute("point").Value.Split(' ').Select(int.Parse).ToArray();

                    var x = pointValue[0];
                    var y = pointValue[1];

                    // Cropping the image to get the 96x96 snippet
                    var croppedImage = CropImage(fullImage, x, y, 96, 96);

                    var iconInfo = new IconInfo
                    {
                        UUID = uuid,
                        Image = croppedImage
                    };

                    iconDataList.Add(uuid.ToUpperInvariant(), iconInfo);
                }
            }

            return iconDataList;
        }

        private static ImageResult CropImage(ImageResult image, int x, int y, int width, int height)
        {
            var croppedData = new byte[width * height * 4];
            var index = 0;

            for (int j = y; j < y + height; j++)
            {
                for (int i = x; i < x + width; i++)
                {
                    var pixelIndex = (j * image.Width + i) * 4;
                    for (int k = 0; k < 4; k++)
                    {
                        croppedData[index++] = image.Data[pixelIndex + k];
                    }
                }
            }

            return new ImageResult
            {
                Width = width,
                Height = height,
                SourceComp = image.SourceComp,
                Comp = image.Comp,
                Data = croppedData
            };
        }

        public static Color ConvertHexToNormalizedRGBA(string hexColor)
        {
            // Remove the hash at the start if it's there
            hexColor = hexColor.Replace("#", string.Empty);

            if (hexColor.Length == 6)
            {
                // If no alpha is provided, assume FF (fully opaque)
                hexColor += "FF";
            }
            else if (hexColor.Length != 8)
            {
                throw new ArgumentException("Invalid hex color format.");
            }

            var r = int.Parse(hexColor.Substring(0, 2), NumberStyles.HexNumber);
            var g = int.Parse(hexColor.Substring(2, 2), NumberStyles.HexNumber);
            var b = int.Parse(hexColor.Substring(4, 2), NumberStyles.HexNumber);
            var a = int.Parse(hexColor.Substring(6, 2), NumberStyles.HexNumber);

            return new Color(r / 255f, g / 255f, b / 255f, a / 255f);
        }
    }

}
