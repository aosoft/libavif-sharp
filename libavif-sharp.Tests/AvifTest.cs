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
