using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibAvif.Tests
{
    public record EncodeParam(int MinQuantizer, int MaxQuantizer, int Speed)
    {
    }

    public class AvifTest
    {
        [Fact]
        public void Test()
        {
            using var rgb = ImageSource.CreateRGBImage(1024, 1024, 8, AvifRGBFormat.RGB);
            using var yuv = rgb.ConvertToYUV(
                AvifPixelFormat.YUV444,
                AvifRange.Full,
                AvifColorPrimaries.BT709,
                AvifTransferCharacteristics.sRGB,
                AvifMatrixCoefficients.BT709);
            using var encoder = new AvifEncoder();
            using var encoded = encoder.Write(yuv);
            using var decoder = new AvifDecoder();
            using var yuv2 = decoder.ReadMemory(encoded);
            using var rgb2 = yuv2.ConvertToRGB();
        }

        private static AvifRWData Encode(AvifImage source, EncodeParam param)
        {
            using var encoder = new AvifEncoder()
            {
                MaxThreads = Environment.ProcessorCount,
                MinQuantizer = param.MinQuantizer,
                MaxQuantizer = param.MaxQuantizer,
                Speed = param.Speed,
            };

            return encoder.Write(source);
        }

        private static AvifImage Decode(AvifReadOnlyData<byte> memory)
        {
            using var decoder = new AvifDecoder()
            {
                MaxThreads = Environment.ProcessorCount,
            };

            return decoder.ReadMemory(memory);
        }
    }
}
