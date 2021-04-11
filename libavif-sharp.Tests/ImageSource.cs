using System;
using System.Collections.Generic;
using System.Text;
using LibAvif.Extensions;

namespace LibAvif.Tests
{
    static class ImageSource
    {
        public static AvifRGBImage CreateRGBImage(uint width, uint height, uint depth, AvifRGBFormat format)
        {
            var ret = AvifRGBImage.Create(width, height, depth, format);
            try
            {
                if (ret.BytePerChannel > 1)
                {
                    InitRGBImage(ret.Pixels16, width, height,
                        (val, max) => (ushort)((double)val / max * 65535.0),
                        (val, max) => (ushort)(65535 - (ushort)((double)val / max * 65535.0)));
                }
                else
                {
                    InitRGBImage(ret.Pixels8, width, height,
                        (val, max) => (byte)((double)val / max * 255.0),
                        (val, max) => (byte)(255 - (ushort)((double)val / max * 255.0)));
                }
            }
            catch
            {
                ret.Dispose();
                throw;
            }
            return ret;
        }

        private static void InitRGBImage<T>(AvifImageData<T> target, uint width, uint height, Func<uint, uint, T> fnCv1, Func<uint, uint, T> fnCv2) where T : unmanaged
        {
            for (uint y = 0; y < height; y++)
            {
                var l = target[y];
                var y1 = fnCv1(y, height);
                var y2 = fnCv2(y, height);
                for (uint x = 0; x < width; x++)
                {
                    var x1 = fnCv1(x, width);
                    var x2 = fnCv2(x, width);
                    if (target.ChannelCount > 3)
                    {
                        l[x * 4] = x1;
                        l[x * 4 + 1] = x2;
                        l[x * 4 + 2] = y1;
                        l[x * 4 + 3] = y2;
                    }
                    else
                    {
                        l[x * 3] = x1;
                        l[x * 3 + 1] = x2;
                        l[x * 3 + 2] = y1;
                    }
                }
            }
        }
    }
}
