using System;
using System.Collections.Generic;
using System.Text;
using LibAvif.Binding;

namespace LibAvif
{
    public enum AvifPixelFormat
    {
        None = avifPixelFormat.AVIF_PIXEL_FORMAT_NONE,
        YUV444 = avifPixelFormat.AVIF_PIXEL_FORMAT_YUV444,
        YUV422 = avifPixelFormat.AVIF_PIXEL_FORMAT_YUV422,
        YUV420 = avifPixelFormat.AVIF_PIXEL_FORMAT_YUV420,
        YUV400 = avifPixelFormat.AVIF_PIXEL_FORMAT_YUV400,
    }

    public enum AvifRange
    {
        Limited = avifRange.AVIF_RANGE_LIMITED,
        Full = avifRange.AVIF_RANGE_FULL,
    }

    public enum AvifChromaSamplePosition
    {
        Unknown = avifChromaSamplePosition.AVIF_CHROMA_SAMPLE_POSITION_UNKNOWN,
        Vertical = avifChromaSamplePosition.AVIF_CHROMA_SAMPLE_POSITION_VERTICAL,
        Colocated = avifChromaSamplePosition.AVIF_CHROMA_SAMPLE_POSITION_COLOCATED,
    }

    public enum AvifColorPrimaries : ushort
    {
        Unknown = avifColorPrimaries.AVIF_COLOR_PRIMARIES_UNKNOWN,
        BT709 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_BT709,
        IEC61966_2_4 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_IEC61966_2_4,
        Unspecfied = avifColorPrimaries.AVIF_COLOR_PRIMARIES_UNSPECIFIED,
        BT470M = avifColorPrimaries.AVIF_COLOR_PRIMARIES_BT470M,
        BT470BG = avifColorPrimaries.AVIF_COLOR_PRIMARIES_BT470BG,
        BT601 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_BT601,
        SMPTE240 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_SMPTE240,
        GenericFilm = avifColorPrimaries.AVIF_COLOR_PRIMARIES_GENERIC_FILM,
        BT2020 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_BT2020,
        XYZ = avifColorPrimaries.AVIF_COLOR_PRIMARIES_XYZ,
        SMPTE431 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_SMPTE431,
        SMPTE432 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_SMPTE432,
        EBU3213 = avifColorPrimaries.AVIF_COLOR_PRIMARIES_EBU3213,
    }

    public enum AvifTransferCharacteristics : ushort
    {
        Unknown = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_UNKNOWN,
        BT709 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT709,
        Unspecified = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_UNSPECIFIED,
        BT470M = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT470M,
        BT470BG = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT470BG,
        BT601 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT601,
        SMPTE240 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_SMPTE240,
        Linear = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_LINEAR,
        Log100 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_LOG100,
        Log100Sqrt10 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_LOG100SQRT10,
        IEC61966 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_IEC61966,
        BT1361 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT1361,
        sRGB = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_SRGB,
        BT2020_10bit = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT2020_10BIT,
        BT2020_12bit = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_BT2020_12BIT,
        SMPTE2084 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_SMPTE2084,
        SMPTE428 = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_SMPTE428,
        HLG = avifTransferCharacteristics.AVIF_TRANSFER_CHARACTERISTICS_HLG,
    }

    public enum AvifMatrixCoefficients : ushort
    {
        Identity = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_IDENTITY,
        BT709 = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_BT709,
        Unspecified = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_UNSPECIFIED,
        FCC = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_FCC,
        BT470BG = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_BT470BG,
        BT601 = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_BT601,
        SMPTE240 = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_SMPTE240,
        YCgCo = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_YCGCO,
        BT2020NCL = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_BT2020NCL,
        BT2020CL = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_BT2020CL,
        SMPTE2085 = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_SMPTE2085,
        ChromaDerivedNCL = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_CHROMA_DERIVED_NCL,
        ChromaDerivedCL = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_CHROMA_DERIVED_CL,
        ICtCp = avifMatrixCoefficients.AVIF_MATRIX_COEFFICIENTS_ICTCP,
    }

    public sealed class AvifImage : IDisposable
    {
        unsafe private IntPtr _native;

        public AvifImage()
        {
            _native = libavif.avifImageCreateEmpty();
        }

        public AvifImage(int width, int height, int depth, AvifPixelFormat yuvFormat)
        {
            _native = libavif.avifImageCreate(width, height, depth, (avifPixelFormat)yuvFormat);
        }

        public AvifImage(IntPtr p)
        {
            _native = p;
        }

        public void Dispose()
        {
            if (_native != IntPtr.Zero)
            {
                libavif.avifImageDestroy(_native);
                _native = IntPtr.Zero;
            }
        }

        unsafe private delegate T FnGet<T>(avifImage* p);
        unsafe private delegate void FnSet<T>(avifImage* p, T value);

        unsafe private T Get<T>(FnGet<T> fn)
        {
            return _native != IntPtr.Zero ? fn((avifImage*)_native) : default(T);
        }
        unsafe private void Set<T>(FnSet<T> fn, T value)
        {
            if (_native != IntPtr.Zero)
            {
                fn((avifImage*)_native, value);
            }
        }

        public uint Width
        {
            get { unsafe { return Get(p => p->width); } }
            set { unsafe { Set((p, v) => p->width = v, value); } }
        }

        public uint Height
        {
            get { unsafe { return Get(p => p->height); } }
            set { unsafe { Set((p, v) => p->height = v, value); } }
        }

        public uint Depth
        {
            get { unsafe { return Get(p => p->depth); } }
            set { unsafe { Set((p, v) => p->depth = v, value); } }
        }

        public AvifPixelFormat YUVFormat
        {
            get { unsafe { return (AvifPixelFormat)Get(p => p->yuvFormat); } }
            set { unsafe { Set((p, v) => p->yuvFormat = v, (avifPixelFormat)value); } }
        }

        public AvifRange YUVRange
        {
            get { unsafe { return (AvifRange)Get(p => p->yuvRange); } }
            set { unsafe { Set((p, v) => p->yuvRange = v, (avifRange)value); } }
        }

        public AvifChromaSamplePosition YUVChromaSamplePosition
        {
            get { unsafe { return (AvifChromaSamplePosition)Get(p => p->yuvChromaSamplePosition); } }
            set { unsafe { Set((p, v) => p->yuvChromaSamplePosition = v, (avifChromaSamplePosition)value); } }
        }

        //internal __IntPtr yuvPlanes;
        //internal fixed uint yuvRowBytes[3];

        public int ImageOwnsYUVPlanes
        {
            get { unsafe { return Get(p => p->imageOwnsYUVPlanes); } }
            set { unsafe { Set((p, v) => p->imageOwnsYUVPlanes = v, value); } }
        }

        public AvifRange AlphaRange
        {
            get { unsafe { return (AvifRange)Get(p => p->alphaRange); } }
            set { unsafe { Set((p, v) => p->alphaRange = v, (avifRange)value); } }
        }

        //internal __IntPtr alphaPlane;
        //internal uint alphaRowBytes;

        public int ImageOwnsAlphaPlane
        {
            get { unsafe { return Get(p => p->imageOwnsAlphaPlane); } }
            set { unsafe { Set((p, v) => p->imageOwnsAlphaPlane = v, value); } }
        }

        public bool AlphaPremultiplied
        {
            get { unsafe { return Get(p => p->alphaPremultiplied) != 0; } }
            set { unsafe { Set((p, v) => p->alphaPremultiplied = v, value ? 1 : 0); } }
        }

        //internal avifRWData icc;

        public AvifColorPrimaries ColorPrimaries
        {
            get { unsafe { return (AvifColorPrimaries)Get(p => p->colorPrimaries); } }
            set { unsafe { Set((p, v) => p->colorPrimaries = v, (ushort)value); } }
        }

        public AvifTransferCharacteristics TransferCharacteristics
        {
            get { unsafe { return (AvifTransferCharacteristics)Get(p => p->transferCharacteristics); } }
            set { unsafe { Set((p, v) => p->transferCharacteristics = v, (ushort)value); } }
        }

        public AvifMatrixCoefficients MatrixCoefficients
        {
            get { unsafe { return (AvifMatrixCoefficients)Get(p => p->matrixCoefficients); } }
            set { unsafe { Set((p, v) => p->matrixCoefficients = v, (ushort)value); } }
        }

        public uint transformFlags;


        /*
        public avifPixelAspectRatioBox pasp;
        public avifCleanApertureBox clap;
        public avifImageRotation irot;
        public avifImageMirror imir;
        public avifRWData exif;
        public avifRWData xmp;
        */

    }
}
