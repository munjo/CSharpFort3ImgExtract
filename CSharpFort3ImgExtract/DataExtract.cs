using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFort3ImgExtract
{
    class DataExtract
    {
        static public string HexData(byte[] data, int lineText = 16)
        {
            StringBuilder text = new StringBuilder((data?.Length ?? 0) * 2);

            for (int i = 0; i < (data?.Length ?? 0); i++)
            {
                if (i != 0)
                {
                    if (i % lineText == 0)
                    {
                        text.Append("\n");
                    }
                    else
                    {
                        text.Append(" ");
                    }
                }
                text.Append(string.Format("{0:X2}", data[i]));
            }

            return text.ToString();
        }

        static public bool ImgSprDecompress(string fileName, List<Fort3Img> fort3ImgList)
        {
            bool result = true;

            using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int total;

                BinaryReader sr = new BinaryReader(fs);

                short unKnown3;
                byte[] unKnown4;
                int outSize, dataSize;
                byte[] outData, readData;

                try
                {
                    total = sr.ReadInt32();
                    if (total <= 0)
                    {
                        Console.WriteLine("잘못된 파일");
                        result = false;
                    }

                    for (int a = 0; a < total; a++)
                    {
                        Fort3Img fort3Img = new Fort3Img();

                        fort3Img.Width = sr.ReadInt32();
                        fort3Img.Height = sr.ReadInt32();
                        fort3Img.ImgData[0].OffsetX = sr.ReadInt32();
                        fort3Img.ImgData[0].OffsetY = sr.ReadInt32();
                        fort3Img.TypeValue = sr.ReadInt32();
                        switch (fort3Img.TypeValue)
                        {
                            case 0x00:
                                fort3Img.Type = Fort3ImgType.TransparentValueImage;
                                break;
                            case 0x17:
                                fort3Img.Type = Fort3ImgType.RGB565Image;
                                break;
                            case 0x19:
                                fort3Img.Type = Fort3ImgType.ARGB1555Image;
                                break;
                            case 0x1a:
                                fort3Img.Type = Fort3ImgType.ARGB4444Image;
                                break;
                            default:
                                fort3Img.Type = Fort3ImgType.Unknown;
                                break;
                        }

                        unKnown3 = sr.ReadInt16();
                        unKnown4 = sr.ReadBytes(0xfe);

                        outSize = sr.ReadInt32();
                        dataSize = sr.ReadInt32();
                        if (dataSize > fs.Length)
                        {
                            throw new Exception("이미지데이터 크기 값이 파일 크기보다 큽니다.");
                        }

                        outData = new byte[outSize];
                        readData = sr.ReadBytes(dataSize);

                        Fort2Decompress.DecompressStart(outData, readData, dataSize, outSize);
                        fort3Img.ImgData[0].Data = outData;

                        fort3ImgList.Add(fort3Img);
                    }
                }
                catch (Exception exc)
                {
                    if (0 < fort3ImgList.Count)
                    {
                        Console.WriteLine("일부 값을 불러오는데 문제가 있음");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 파일");
                        result = false;
                    }

                    Console.WriteLine(exc);
                }
            }

            return result;
        }

        static public bool I16Decompress(string fileName, List<Fort3Img> fort3ImgList)
        {
            bool result = true;

            using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int total;
                int outSize, dataSize;
                byte[] outData, readMem;

                BinaryReader sr = new BinaryReader(fs);

                try
                {
                    total = sr.ReadInt32();
                    if (total <= 0)
                    {
                        Console.WriteLine("잘못된 파일");
                        result = false;
                    }

                    for (int a = 0; a < total; a++)
                    {
                        Fort3Img fort3Img = new Fort3Img();

                        fort3Img.TypeValue = sr.ReadInt32();
                        if (fort3Img.TypeValue == 0)
                        {
                            fort3Img.Type = Fort3ImgType.TransparentValueImageI16;
                        }
                        else if (fort3Img.TypeValue == 1)
                        {
                            fort3Img.Type = Fort3ImgType.RGB565Image;
                        }
                        else
                        {
                            throw new Exception("이미지의 타입값이 옳바르지 않음");
                        }

                        fort3Img.Width = sr.ReadInt32();
                        fort3Img.Height = sr.ReadInt32();

                        fort3Img.ImgData[0].OffsetX = sr.ReadInt16();
                        fort3Img.ImgData[0].OffsetY = sr.ReadInt16();
                        outSize = sr.ReadInt32();
                        dataSize = sr.ReadInt32();
                        outSize *= 2;

                        if (dataSize > fs.Length)
                        {
                            throw new Exception("이미지데이터 크기 값이 파일 크기보다 큽니다.");
                        }
                        readMem = sr.ReadBytes(dataSize);
                        outData = new byte[outSize];

                        Fort2Decompress.DecompressStart(outData, readMem, dataSize, outSize);
                        fort3Img.ImgData[0].Data = outData;

                        outSize = sr.ReadInt32();
                        outSize *= 2;

                        if (outSize != 0)
                        {
                            fort3Img.ImgData[1].OffsetX = sr.ReadInt16();
                            fort3Img.ImgData[1].OffsetY = sr.ReadInt16();
                            dataSize = sr.ReadInt32();
                            if (dataSize > fs.Length)
                            {
                                throw new Exception("이미지데이터 크기 값이 파일 크기보다 큽니다.");
                            }
                            readMem = sr.ReadBytes(dataSize);
                            outData = new byte[outSize];

                            Fort2Decompress.DecompressStart(outData, readMem, dataSize, outSize);
                            fort3Img.ImgData[1].Data = outData;
                        }

                        fort3ImgList.Add(fort3Img);
                    }
                }
                catch (Exception exc)
                {
                    if (0 < fort3ImgList.Count)
                    {
                        Console.WriteLine("일부 값을 불러오는데 문제가 있음");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 파일");
                        result = false;
                    }

                    Console.WriteLine(exc);
                }
            }

            return result;
        }
    }
}
