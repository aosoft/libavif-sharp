using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace LibAvif.Binding
{
    internal enum avifPlanesFlags
    {
        AVIF_PLANES_YUV = 1,
        AVIF_PLANES_A = 2,
        AVIF_PLANES_ALL = 255
    }

    internal enum avifChannelIndex
    {
        AVIF_CHAN_R = 0,
        AVIF_CHAN_G = 1,
        AVIF_CHAN_B = 2,
        AVIF_CHAN_Y = 0,
        AVIF_CHAN_U = 1,
        AVIF_CHAN_V = 2
    }

    internal enum avifResult
    {
        AVIF_RESULT_OK = 0,
        AVIF_RESULT_UNKNOWN_ERROR = 1,
        AVIF_RESULT_INVALID_FTYP = 2,
        AVIF_RESULT_NO_CONTENT = 3,
        AVIF_RESULT_NO_YUV_FORMAT_SELECTED = 4,
        AVIF_RESULT_REFORMAT_FAILED = 5,
        AVIF_RESULT_UNSUPPORTED_DEPTH = 6,
        AVIF_RESULT_ENCODE_COLOR_FAILED = 7,
        AVIF_RESULT_ENCODE_ALPHA_FAILED = 8,
        AVIF_RESULT_BMFF_PARSE_FAILED = 9,
        AVIF_RESULT_NO_AV1ITEMS_FOUND = 10,
        AVIF_RESULT_DECODE_COLOR_FAILED = 11,
        AVIF_RESULT_DECODE_ALPHA_FAILED = 12,
        AVIF_RESULT_COLOR_ALPHA_SIZE_MISMATCH = 13,
        AVIF_RESULT_ISPE_SIZE_MISMATCH = 14,
        AVIF_RESULT_NO_CODEC_AVAILABLE = 15,
        AVIF_RESULT_NO_IMAGES_REMAINING = 16,
        AVIF_RESULT_INVALID_EXIF_PAYLOAD = 17,
        AVIF_RESULT_INVALID_IMAGE_GRID = 18,
        AVIF_RESULT_INVALID_CODEC_SPECIFIC_OPTION = 19,
        AVIF_RESULT_TRUNCATED_DATA = 20,
        AVIF_RESULT_IO_NOT_SET = 21,
        AVIF_RESULT_IO_ERROR = 22,
        AVIF_RESULT_WAITING_ON_IO = 23,
        AVIF_RESULT_INVALID_ARGUMENT = 24,
        AVIF_RESULT_NOT_IMPLEMENTED = 25
    }

    internal enum avifPixelFormat
    {
        AVIF_PIXEL_FORMAT_NONE = 0,
        AVIF_PIXEL_FORMAT_YUV444 = 1,
        AVIF_PIXEL_FORMAT_YUV422 = 2,
        AVIF_PIXEL_FORMAT_YUV420 = 3,
        AVIF_PIXEL_FORMAT_YUV400 = 4
    }

    internal enum avifChromaSamplePosition
    {
        AVIF_CHROMA_SAMPLE_POSITION_UNKNOWN = 0,
        AVIF_CHROMA_SAMPLE_POSITION_VERTICAL = 1,
        AVIF_CHROMA_SAMPLE_POSITION_COLOCATED = 2
    }

    internal enum avifRange
    {
        AVIF_RANGE_LIMITED = 0,
        AVIF_RANGE_FULL = 1
    }

    internal enum avifPrimaries
    {
        AVIF_COLOR_PRIMARIES_UNKNOWN = 0,
        AVIF_COLOR_PRIMARIES_BT709 = 1,
        AVIF_COLOR_PRIMARIES_IEC61966_2_4 = 1,
        AVIF_COLOR_PRIMARIES_UNSPECIFIED = 2,
        AVIF_COLOR_PRIMARIES_BT470M = 4,
        AVIF_COLOR_PRIMARIES_BT470BG = 5,
        AVIF_COLOR_PRIMARIES_BT601 = 6,
        AVIF_COLOR_PRIMARIES_SMPTE240 = 7,
        AVIF_COLOR_PRIMARIES_GENERIC_FILM = 8,
        AVIF_COLOR_PRIMARIES_BT2020 = 9,
        AVIF_COLOR_PRIMARIES_XYZ = 10,
        AVIF_COLOR_PRIMARIES_SMPTE431 = 11,
        AVIF_COLOR_PRIMARIES_SMPTE432 = 12,
        AVIF_COLOR_PRIMARIES_EBU3213 = 22
    }

    internal enum avifTransferCharacteristics
    {
        AVIF_TRANSFER_CHARACTERISTICS_UNKNOWN = 0,
        AVIF_TRANSFER_CHARACTERISTICS_BT709 = 1,
        AVIF_TRANSFER_CHARACTERISTICS_UNSPECIFIED = 2,
        AVIF_TRANSFER_CHARACTERISTICS_BT470M = 4,
        AVIF_TRANSFER_CHARACTERISTICS_BT470BG = 5,
        AVIF_TRANSFER_CHARACTERISTICS_BT601 = 6,
        AVIF_TRANSFER_CHARACTERISTICS_SMPTE240 = 7,
        AVIF_TRANSFER_CHARACTERISTICS_LINEAR = 8,
        AVIF_TRANSFER_CHARACTERISTICS_LOG100 = 9,
        AVIF_TRANSFER_CHARACTERISTICS_LOG100SQRT10 = 10,
        AVIF_TRANSFER_CHARACTERISTICS_IEC61966 = 11,
        AVIF_TRANSFER_CHARACTERISTICS_BT1361 = 12,
        AVIF_TRANSFER_CHARACTERISTICS_SRGB = 13,
        AVIF_TRANSFER_CHARACTERISTICS_BT2020_10BIT = 14,
        AVIF_TRANSFER_CHARACTERISTICS_BT2020_12BIT = 15,
        AVIF_TRANSFER_CHARACTERISTICS_SMPTE2084 = 16,
        AVIF_TRANSFER_CHARACTERISTICS_SMPTE428 = 17,
        AVIF_TRANSFER_CHARACTERISTICS_HLG = 18
    }

    internal enum avifMatrixCoefficients
    {
        AVIF_MATRIX_COEFFICIENTS_IDENTITY = 0,
        AVIF_MATRIX_COEFFICIENTS_BT709 = 1,
        AVIF_MATRIX_COEFFICIENTS_UNSPECIFIED = 2,
        AVIF_MATRIX_COEFFICIENTS_FCC = 4,
        AVIF_MATRIX_COEFFICIENTS_BT470BG = 5,
        AVIF_MATRIX_COEFFICIENTS_BT601 = 6,
        AVIF_MATRIX_COEFFICIENTS_SMPTE240 = 7,
        AVIF_MATRIX_COEFFICIENTS_YCGCO = 8,
        AVIF_MATRIX_COEFFICIENTS_BT2020NCL = 9,
        AVIF_MATRIX_COEFFICIENTS_BT2020CL = 10,
        AVIF_MATRIX_COEFFICIENTS_SMPTE2085 = 11,
        AVIF_MATRIX_COEFFICIENTS_CHROMA_DERIVED_NCL = 12,
        AVIF_MATRIX_COEFFICIENTS_CHROMA_DERIVED_CL = 13,
        AVIF_MATRIX_COEFFICIENTS_ICTCP = 14
    }

    [Flags]
    internal enum avifTransformationFlags
    {
        AVIF_TRANSFORM_NONE = 0,
        AVIF_TRANSFORM_PASP = 1,
        AVIF_TRANSFORM_CLAP = 2,
        AVIF_TRANSFORM_IROT = 4,
        AVIF_TRANSFORM_IMIR = 8
    }

    internal enum avifRGBFormat
    {
        AVIF_RGB_FORMAT_RGB = 0,
        AVIF_RGB_FORMAT_RGBA = 1,
        AVIF_RGB_FORMAT_ARGB = 2,
        AVIF_RGB_FORMAT_BGR = 3,
        AVIF_RGB_FORMAT_BGRA = 4,
        AVIF_RGB_FORMAT_ABGR = 5
    }

    internal enum avifChromaUpsampling
    {
        AVIF_CHROMA_UPSAMPLING_AUTOMATIC = 0,
        AVIF_CHROMA_UPSAMPLING_FASTEST = 1,
        AVIF_CHROMA_UPSAMPLING_BEST_QUALITY = 2,
        AVIF_CHROMA_UPSAMPLING_NEAREST = 3,
        AVIF_CHROMA_UPSAMPLING_BILINEAR = 4
    }

    internal enum avifCodecChoice
    {
        AVIF_CODEC_CHOICE_AUTO = 0,
        AVIF_CODEC_CHOICE_AOM = 1,
        AVIF_CODEC_CHOICE_DAV1D = 2,
        AVIF_CODEC_CHOICE_LIBGAV1 = 3,
        AVIF_CODEC_CHOICE_RAV1E = 4,
        AVIF_CODEC_CHOICE_SVT = 5
    }

    internal enum avifCodecFlags
    {
        AVIF_CODEC_FLAG_CAN_DECODE = 1,
        AVIF_CODEC_FLAG_CAN_ENCODE = 2
    }

    internal enum avifDecoderSource
    {
        AVIF_DECODER_SOURCE_AUTO = 0,
        AVIF_DECODER_SOURCE_PRIMARY_ITEM = 1,
        AVIF_DECODER_SOURCE_TRACKS = 2
    }

    internal enum avifAddImageFlags
    {
        AVIF_ADD_IMAGE_FLAG_NONE = 0,
        AVIF_ADD_IMAGE_FLAG_FORCE_KEYFRAME = 1,
        AVIF_ADD_IMAGE_FLAG_SINGLE = 2
    }




    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
    internal delegate void avifIODestroyFunc(__IntPtr io);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
    internal delegate avifResult avifIOReadFunc(__IntPtr io, uint readFlags, ulong offset, ulong size, __IntPtr @out);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
    internal unsafe delegate avifResult avifIOWriteFunc(__IntPtr io, uint writeFlags, ulong offset, byte* data, ulong size);




    [StructLayout(LayoutKind.Sequential, Size = 16)]
    internal struct avifROData
    {
        internal __IntPtr data;
        internal ulong size;
    }

    internal struct avifDecoderData
    {
    }

    internal struct avifEncoderData
    {
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    internal struct avifRWData
    {
        internal __IntPtr data;
        internal ulong size;
    }

    [StructLayout(LayoutKind.Sequential, Size = 12)]
    internal struct avifPixelFormatInfo
    {
        internal int monochrome;
        internal int chromaShiftX;
        internal int chromaShiftY;
    }

    [StructLayout(LayoutKind.Sequential, Size = 8)]
    internal struct avifPixelAspectRatioBox
    {
        internal uint hSpacing;
        internal uint vSpacing;
    }

    [StructLayout(LayoutKind.Sequential, Size = 32)]
    internal struct avifCleanApertureBox
    {
        internal uint widthN;
        internal uint widthD;
        internal uint heightN;
        internal uint heightD;
        internal uint horizOffN;
        internal uint horizOffD;
        internal uint vertOffN;
        internal uint vertOffD;
    }

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    internal struct avifImageRotation
    {
        internal byte angle;
    }

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    internal struct avifImageMirror
    {
        internal byte axis;
    }

    [StructLayout(LayoutKind.Sequential, Size = 200)]
    unsafe internal struct avifImage
    {
        internal uint width;
        internal uint height;
        internal uint depth;
        internal avifPixelFormat yuvFormat;
        internal avifRange yuvRange;
        internal avifChromaSamplePosition yuvChromaSamplePosition;
        internal __IntPtr yuvPlanes;
        internal fixed uint yuvRowBytes[3];
        internal int imageOwnsYUVPlanes;
        internal avifRange alphaRange;
        internal __IntPtr alphaPlane;
        internal uint alphaRowBytes;
        internal int imageOwnsAlphaPlane;
        internal int alphaPremultiplied;
        internal avifRWData icc;
        internal ushort colorPrimaries;
        internal ushort transferCharacteristics;
        internal ushort matrixCoefficients;
        internal uint transformFlags;
        internal avifPixelAspectRatioBox pasp;
        internal avifCleanApertureBox clap;
        internal avifImageRotation irot;
        internal avifImageMirror imir;
        internal avifRWData exif;
        internal avifRWData xmp;
    }

    [StructLayout(LayoutKind.Sequential, Size = 48)]
    internal struct avifRGBImage
    {
        internal uint width;
        internal uint height;
        internal uint depth;
        internal avifRGBFormat format;
        internal avifChromaUpsampling chromaUpsampling;
        internal int ignoreAlpha;
        internal int alphaPremultiplied;
        internal __IntPtr pixels;
        internal uint rowBytes;
    }

    [StructLayout(LayoutKind.Sequential, Size = 9)]
    internal struct avifCodecConfigurationBox
    {
        internal byte seqProfile;
        internal byte seqLevelIdx0;
        internal byte seqTier0;
        internal byte highBitdepth;
        internal byte twelveBit;
        internal byte monochrome;
        internal byte chromaSubsamplingX;
        internal byte chromaSubsamplingY;
        internal byte chromaSamplePosition;
    }

    [StructLayout(LayoutKind.Sequential, Size = 48)]
    internal struct avifIO
    {
        internal __IntPtr destroy;
        internal __IntPtr read;
        internal __IntPtr write;
        internal ulong sizeHint;
        internal int persistent;
        internal __IntPtr data;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    internal struct avifIOStats
    {
        internal ulong colorOBUSize;
        internal ulong alphaOBUSize;
    }

    [StructLayout(LayoutKind.Sequential, Size = 40)]
    internal struct avifImageTiming
    {
        internal ulong timescale;
        internal double pts;
        internal ulong ptsInTimescales;
        internal double duration;
        internal ulong durationInTimescales;
    }


    [StructLayout(LayoutKind.Sequential, Size = 144)]
    internal struct avifDecoder
    {
        internal avifCodecChoice codecChoice;
        internal int maxThreads;
        internal avifDecoderSource requestedSource;
        internal __IntPtr image;
        internal int imageIndex;
        internal int imageCount;
        internal avifImageTiming imageTiming;
        internal ulong timescale;
        internal double duration;
        internal ulong durationInTimescales;
        internal int alphaPresent;
        internal int ignoreExif;
        internal int ignoreXMP;
        internal uint imageCountLimit;
        internal avifIOStats ioStats;
        internal __IntPtr io;
        internal __IntPtr data;
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    internal struct avifExtent
    {
        internal ulong offset;
        internal ulong size;
    }


    [StructLayout(LayoutKind.Sequential, Size = 80)]
    internal struct avifEncoder
    {
        internal avifCodecChoice codecChoice;
        internal int maxThreads;
        internal int minQuantizer;
        internal int maxQuantizer;
        internal int minQuantizerAlpha;
        internal int maxQuantizerAlpha;
        internal int tileRowsLog2;
        internal int tileColsLog2;
        internal int speed;
        internal int keyframeInterval;
        internal ulong timescale;
        internal avifIOStats ioStats;
        internal __IntPtr data;
        internal __IntPtr csOptions;
    }


    internal static class libavif
    {
        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifVersion", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifVersion();

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifCodecVersions", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifCodecVersions(sbyte[] outBuffer);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifLibYUVVersion", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern uint avifLibYUVVersion();

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifAlloc", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifAlloc(ulong size);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifFree", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifFree(__IntPtr p);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifResultToString", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifResultToString(avifResult result);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRWDataRealloc", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifRWDataRealloc(__IntPtr raw, ulong newSize);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRWDataSet", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern void avifRWDataSet(__IntPtr raw, byte* data, ulong len);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRWDataFree", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifRWDataFree(__IntPtr raw);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifPixelFormatToString", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifPixelFormatToString(avifPixelFormat format);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifGetPixelFormatInfo", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifGetPixelFormatInfo(avifPixelFormat format, __IntPtr info);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifColorPrimariesGetValues", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifColorPrimariesGetValues(ushort acp, float[] outPrimaries);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifColorPrimariesFind", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern ushort avifColorPrimariesFind(float[] inPrimaries, sbyte** outName);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageCreate", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifImageCreate(int width, int height, int depth, avifPixelFormat yuvFormat);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageCreateEmpty", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifImageCreateEmpty();

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageCopy", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifImageCopy(__IntPtr dstImage, __IntPtr srcImage, uint planes);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageDestroy", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifImageDestroy(__IntPtr image);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageSetProfileICC", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern void avifImageSetProfileICC(__IntPtr image, byte* icc, ulong iccSize);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageSetMetadataExif", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern void avifImageSetMetadataExif(__IntPtr image, byte* exif, ulong exifSize);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageSetMetadataXMP", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern void avifImageSetMetadataXMP(__IntPtr image, byte* xmp, ulong xmpSize);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageAllocatePlanes", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifImageAllocatePlanes(__IntPtr image, uint planes);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageFreePlanes", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifImageFreePlanes(__IntPtr image, uint planes);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageStealPlanes", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifImageStealPlanes(__IntPtr dstImage, __IntPtr srcImage, uint planes);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBFormatChannelCount", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern uint avifRGBFormatChannelCount(avifRGBFormat format);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBFormatHasAlpha", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifRGBFormatHasAlpha(avifRGBFormat format);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBImageSetDefaults", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifRGBImageSetDefaults(__IntPtr rgb, __IntPtr image);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBImagePixelSize", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern uint avifRGBImagePixelSize(__IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBImageAllocatePixels", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifRGBImageAllocatePixels(__IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBImageFreePixels", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifRGBImageFreePixels(__IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageRGBToYUV", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifImageRGBToYUV(__IntPtr image, __IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageYUVToRGB", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifImageYUVToRGB(__IntPtr image, __IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBImagePremultiplyAlpha", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifRGBImagePremultiplyAlpha(__IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifRGBImageUnpremultiplyAlpha", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifRGBImageUnpremultiplyAlpha(__IntPtr rgb);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifFullToLimitedY", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifFullToLimitedY(int depth, int v);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifFullToLimitedUV", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifFullToLimitedUV(int depth, int v);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifLimitedToFullY", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifLimitedToFullY(int depth, int v);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifLimitedToFullUV", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifLimitedToFullUV(int depth, int v);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifCodecName", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifCodecName(avifCodecChoice choice, uint requiredFlags);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifCodecChoiceFromName", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifCodecChoice avifCodecChoiceFromName([MarshalAs(UnmanagedType.LPStr)] string name);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifIOCreateMemoryReader", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern __IntPtr avifIOCreateMemoryReader(byte* data, ulong size);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifIOCreateFileReader", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifIOCreateFileReader([MarshalAs(UnmanagedType.LPStr)] string filename);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifIODestroy", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifIODestroy(__IntPtr io);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderCreate", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifDecoderCreate();

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderDestroy", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifDecoderDestroy(__IntPtr decoder);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderRead", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderRead(__IntPtr decoder, __IntPtr image);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderReadMemory", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern avifResult avifDecoderReadMemory(__IntPtr decoder, __IntPtr image, byte* data, ulong size);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderReadFile", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderReadFile(__IntPtr decoder, __IntPtr image, [MarshalAs(UnmanagedType.LPStr)] string filename);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderSetSource", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderSetSource(__IntPtr decoder, avifDecoderSource source);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderSetIO", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifDecoderSetIO(__IntPtr decoder, __IntPtr io);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderSetIOMemory", CallingConvention = __CallingConvention.Cdecl)]
        internal unsafe static extern avifResult avifDecoderSetIOMemory(__IntPtr decoder, byte* data, ulong size);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderSetIOFile", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderSetIOFile(__IntPtr decoder, [MarshalAs(UnmanagedType.LPStr)] string filename);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderParse", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderParse(__IntPtr decoder);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderNextImage", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderNextImage(__IntPtr decoder);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderNthImage", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderNthImage(__IntPtr decoder, uint frameIndex);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderReset", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderReset(__IntPtr decoder);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderIsKeyframe", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifDecoderIsKeyframe(__IntPtr decoder, uint frameIndex);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderNearestKeyframe", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern uint avifDecoderNearestKeyframe(__IntPtr decoder, uint frameIndex);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderNthImageTiming", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderNthImageTiming(__IntPtr decoder, uint frameIndex, __IntPtr outTiming);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifDecoderNthImageMaxExtent", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifDecoderNthImageMaxExtent(__IntPtr decoder, uint frameIndex, __IntPtr outExtent);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderCreate", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern __IntPtr avifEncoderCreate();

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderWrite", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifEncoderWrite(__IntPtr encoder, __IntPtr image, __IntPtr output);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderDestroy", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifEncoderDestroy(__IntPtr encoder);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderAddImage", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifEncoderAddImage(__IntPtr encoder, __IntPtr image, ulong durationInTimescales, uint addImageFlags);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderAddImageGrid", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifEncoderAddImageGrid(__IntPtr encoder, uint gridCols, uint gridRows, __IntPtr cellImages, uint addImageFlags);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderFinish", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern avifResult avifEncoderFinish(__IntPtr encoder, __IntPtr output);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifEncoderSetCodecSpecificOption", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern void avifEncoderSetCodecSpecificOption(__IntPtr encoder, [MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifImageUsesU16", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifImageUsesU16(__IntPtr image);

        [SuppressUnmanagedCodeSecurity, DllImport("avif", EntryPoint = "avifPeekCompatibleFileType", CallingConvention = __CallingConvention.Cdecl)]
        internal static extern int avifPeekCompatibleFileType(__IntPtr input);
    }

}
