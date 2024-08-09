using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFort3ImgExtract
{
    class ImageConversion
    {
        static public DirectBitmap Fort3ImgDraw(Fort3Img fort3Img, int layer)
        {
            DirectBitmap bitmap = null;

            try
            {
                if (fort3Img.Width != 0 && fort3Img.Height != 0)
                {
                    bitmap = new DirectBitmap(fort3Img.Width, fort3Img.Height);

                    if (fort3Img.Type == Fort3ImgType.TransparentValueImage 
                        || fort3Img.Type == Fort3ImgType.TransparentValueImageI16)
                    {
                        DrawBitmapWithTransparency(fort3Img.ImgData[layer].Data, bitmap, fort3Img.Type);
                    }
                    else
                    {
                        DrawBitmap(fort3Img.ImgData[layer].Data, bitmap, fort3Img.Type);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

            return bitmap;
        }

        static private void DrawBitmapWithTransparency(byte[] data, DirectBitmap bitmap, Fort3ImgType type)
        {
            int Startoffset = 0;
            Point drawPos = new Point();

            while (Startoffset < data.Length)
            {
                if (drawPos.Y >= bitmap.Height)
                {
                    break;
                }

                int offset = Startoffset;
                ushort total = BitConverter.ToUInt16(data, offset);
                ushort lineData = BitConverter.ToUInt16(data, offset + 2);
                offset += 4;
                for (int a = 0; a < lineData; a++)
                {
                    ushort xOffset = BitConverter.ToUInt16(data, offset);
                    drawPos.X = xOffset;
                    ushort dataSize = BitConverter.ToUInt16(data, offset + 2);
                    dataSize *= 2;
                    offset += 4;
                    for (int b = 0; b < dataSize; b += 2)
                    {
                        if (drawPos.X >= bitmap.Width)
                        {
                            return;
                        }
                        ushort value = BitConverter.ToUInt16(data, offset + b);
                        bitmap.SetPixel(drawPos.X, drawPos.Y, HighColorRGB565Return(value));
                        drawPos.X++;
                    }
                    offset += dataSize;
                }
                if (total != 0)
                {
                    if (type == Fort3ImgType.TransparentValueImage)
                    {
                        total *= 2;
                    }
                    Startoffset += total;
                }
                else
                {
                    Startoffset = data.Length;
                }

                drawPos.Y++;
                drawPos.X = 0;
            }
        }

        static private void DrawBitmap(byte[] data, DirectBitmap bitmap, Fort3ImgType type)
        {
            Point drawPos = new Point();
            for (int a = 0; a < data.Length; a += 2)
            {
                if (drawPos.Y >= bitmap.Height)
                {
                    break;
                }

                ushort value = BitConverter.ToUInt16(data, a);

                Color color;

                switch (type)
                {
                    case Fort3ImgType.RGB565Image:
                        color = HighColorRGB565Return(value);
                        break;
                    case Fort3ImgType.ARGB1555Image:
                        color = HighColorARGB1555Return(value);
                        break;
                    case Fort3ImgType.ARGB4444Image:
                        color = HighColorARGB4444Return(value);
                        break;
                    default:
                        return;
                }
                bitmap.SetPixel(drawPos.X, drawPos.Y, color);
                drawPos.X++;

                if (drawPos.X >= bitmap.Width)
                {
                    drawPos.Y++;
                    drawPos.X = 0;
                }
            }
        }


        static public Color HighColorRGB565Return(ushort value)
        {
            int red = value >> 11;
            int green = value >> 5 & 63;
            int blue = value & 31;

            red = red * 8;
            green = green * 4;
            blue = blue * 8;

            Color result = Color.FromArgb(red, green, blue);

            return result;
        }

        static public Color HighColorARGB1555Return(ushort value)
        {
            int alpha = value >> 15;
            int red = value >> 10 & 31;
            int green = value >> 5 & 31;
            int blue = value & 31;

            alpha = alpha * 255;
            red = red * 8;
            green = green * 8;
            blue = blue * 8;

            Color result = Color.FromArgb(alpha, red, green, blue);

            return result;
        }

        static public Color HighColorARGB4444Return(ushort value)
        {
            int alpha = value >> 12;
            int red = value >> 8 & 15;
            int green = value >> 4 & 15;
            int blue = value & 15;

            alpha = alpha * 16;
            red = red * 16;
            green = green * 16;
            blue = blue * 16;

            Color result = Color.FromArgb(alpha, red, green, blue);

            return result;
        }
    }
}
