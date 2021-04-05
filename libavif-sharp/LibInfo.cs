using System.Runtime.InteropServices;
using LibAvif.Binding;

namespace LibAvif
{
    public enum AvifCodecChoice
    {
        Auto = avifCodecChoice.AVIF_CODEC_CHOICE_AUTO,
        AOM = avifCodecChoice.AVIF_CODEC_CHOICE_AOM,
        Dav1d = avifCodecChoice.AVIF_CODEC_CHOICE_DAV1D,
        LibGav1 = avifCodecChoice.AVIF_CODEC_CHOICE_LIBGAV1,
        Rav1e = avifCodecChoice.AVIF_CODEC_CHOICE_RAV1E,
        SVT = avifCodecChoice.AVIF_CODEC_CHOICE_SVT,
    }

    public enum AvifCodecFlags : uint
    {
        Decode = avifCodecFlags.AVIF_CODEC_FLAG_CAN_DECODE,
        Encode = avifCodecFlags.AVIF_CODEC_FLAG_CAN_ENCODE,
    }


    public static class LibInfo
    {
        public static string Version => Marshal.PtrToStringAnsi(libavif.avifVersion());

        public static string GetCodecName(AvifCodecChoice choice, AvifCodecFlags requiredFlags) =>
            Marshal.PtrToStringAnsi(libavif.avifCodecName((avifCodecChoice)choice, (uint)requiredFlags));
    }
}
