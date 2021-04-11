using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LibAvif.Tests
{
    public class AvifTest
    {
        public static void Main()
        {
            using var rgb = ImageSource.CreateRGBImage(1024, 1024, 8, AvifRGBFormat.RGB);
            using var yuv = rgb.ConvertToYUV(
                8,
                AvifPixelFormat.YUV444,
                AvifRange.Full,
                AvifColorPrimaries.BT709,
                AvifTransferCharacteristics.sRGB,
                AvifMatrixCoefficients.BT709);
            using var encoder = new AvifEncoder();
            encoder.MaxThreads = Environment.ProcessorCount;
            using var encoded = encoder.Write(yuv);

            unsafe
            {
                using var s = new FileStream("test.avif", FileMode.Create);
                using var bs = new BufferedStream(s);
                var d = encoded.GetData<byte>();
                bs.Write(new ReadOnlySpan<byte>(d.Pointer.ToPointer(), (int)d.Count));
            }

            using var decoder = new AvifDecoder();
            decoder.MaxThreads = Environment.ProcessorCount;
            using var yuv2 = decoder.ReadMemory(encoded);
            Console.WriteLine($"{yuv2.ColorPrimaries} / {yuv2.TransferCharacteristics} / {yuv2.MatrixCoefficients}");
            using var rgb2 = yuv2.ConvertToRGB();
        }
    }
}
