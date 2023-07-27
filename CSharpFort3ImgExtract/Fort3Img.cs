using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFort3ImgExtract
{
    class Fort3Img
    {
        public Fort3ImgType Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int TypeValue { get; set; }
        public Fort3ImgData[] ImgData { get => imgData; }

        Fort3ImgData[] imgData;

        public Fort3Img()
        {
            this.imgData = new Fort3ImgData[2];
            for(int i = 0; i < 2; i++)
            {
                this.imgData[i] = new Fort3ImgData();
            }
        }
    }

    class Fort3ImgData
    {
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public byte[] Data { get; set; }
    }

    public enum Fort3ImgType
    {
        TransparentValueImageI16 = 0,
        TransparentValueImage,
        RGB565Image,
        ARGB1555Image,
        ARGB4444Image,
        Unknown
    }
}
