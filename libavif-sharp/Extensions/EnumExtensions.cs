using System;
using System.Collections.Generic;
using System.Text;
using LibAvif.Binding;

namespace LibAvif.Extensions
{
    public static class EnumExtensions
    {
        public static uint GetChannelCount(this AvifRGBFormat format) => libavif.avifRGBFormatChannelCount((avifRGBFormat)format);

        public static bool HasAlpha(this AvifRGBFormat format) => libavif.avifRGBFormatHasAlpha((avifRGBFormat)format) != 0;
    }
}
