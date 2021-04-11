using System;
using LibAvif.Binding;

namespace LibAvif
{
    [Flags]
    public enum AvifPlanesFlags : uint
    {
        YUV = avifPlanesFlags.AVIF_PLANES_YUV,
        A = avifPlanesFlags.AVIF_PLANES_A,
        All = avifPlanesFlags.AVIF_PLANES_ALL,
    }


    public enum AvifChannelIndex
    {
        R = avifChannelIndex.AVIF_CHAN_R,
        G = avifChannelIndex.AVIF_CHAN_G,
        B = avifChannelIndex.AVIF_CHAN_B,
        Y = avifChannelIndex.AVIF_CHAN_Y,
        U = avifChannelIndex.AVIF_CHAN_U,
        V = avifChannelIndex.AVIF_CHAN_V,
    }

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

    [Flags]
    public enum AvifTransformationFlags : uint
    {
        None = avifTransformationFlags.AVIF_TRANSFORM_NONE,
        PASP = avifTransformationFlags.AVIF_TRANSFORM_PASP,
        CLAP = avifTransformationFlags.AVIF_TRANSFORM_CLAP,
        IROT = avifTransformationFlags.AVIF_TRANSFORM_IROT,
        IMIR = avifTransformationFlags.AVIF_TRANSFORM_IMIR,
    }

    public readonly struct AvifPixelAspectRatioBox
    {
        public uint HSpacing { get; }
        public uint VSpacing { get; }

        public AvifPixelAspectRatioBox(uint hSpacing, uint vSpacing)
        {
            HSpacing = hSpacing;
            VSpacing = vSpacing;
        }

        internal static AvifPixelAspectRatioBox From(avifPixelAspectRatioBox src) => new AvifPixelAspectRatioBox(src.hSpacing, src.vSpacing);
        internal avifPixelAspectRatioBox To() => new avifPixelAspectRatioBox() { hSpacing = HSpacing, vSpacing = VSpacing };
    }

    public readonly struct AvifCleanApertureBox
    {
        public Fraction Width { get; }
        public Fraction Height { get; }
        public Fraction HorizOff { get; }
        public Fraction VertOff { get; }

        public AvifCleanApertureBox(Fraction width, Fraction height, Fraction horizOff, Fraction vertOff)
        {
            Width = width;
            Height = height;
            HorizOff = horizOff;
            VertOff = vertOff;
        }

        internal static AvifCleanApertureBox From(avifCleanApertureBox src) => new AvifCleanApertureBox(
            new Fraction(src.widthN, src.widthD),
            new Fraction(src.heightN, src.heightD),
            new Fraction(src.horizOffN, src.horizOffD),
            new Fraction(src.vertOffN, src.vertOffD));

        internal avifCleanApertureBox To() => new avifCleanApertureBox() {
            widthN = Width.Numerator,
            widthD = Width.Denominator,
            heightN = Height.Numerator,
            heightD = Height.Denominator,
            horizOffN = HorizOff.Numerator,
            horizOffD = HorizOff.Denominator,
            vertOffN = VertOff.Numerator,
            vertOffD = VertOff.Denominator,
        };
    }

    public readonly ref struct AvifImagePlanes<T> where T : unmanaged
    {
        private readonly IntPtr _nativeAvifImage;

        internal AvifImagePlanes(IntPtr nativeAvifImage)
        {
            _nativeAvifImage = nativeAvifImage;
        }

        public AvifImageData<T> this[AvifChannelIndex index]
        {
            get
            {
                unsafe
                {
                    var native = (avifImage*)_nativeAvifImage;
                    var pp = (byte**)&native->yuvPlanes0;
                    var index2 = (int)index;

                    uint w = native->width;
                    uint h = native->height;

                    var format = (AvifPixelFormat)native->yuvFormat;
                    if (index != AvifChannelIndex.Y && format != AvifPixelFormat.None)
                    {
                        switch (format)
                        {
                            case AvifPixelFormat.YUV422:
                                w /= 2;
                                break;
                            case AvifPixelFormat.YUV420:
                                w /= 2;
                                h /= 2;
                                break;
                            case AvifPixelFormat.YUV400:
                                return default;
                        }
                    }

                    return new AvifImageData<T>(1, w, h, new IntPtr(pp[index2]), native->yuvRowBytes[index2]);
                }
            }
        }
    }

    public sealed class AvifImage : IDisposable
    {
        private bool _disposedValue;
        private IntPtr _native;

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

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (_native != IntPtr.Zero)
                {
                    libavif.avifImageDestroy(_native);
                    _native = IntPtr.Zero;
                }
                _disposedValue = true;
            }
        }

        ~AvifImage()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
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

        unsafe public IntPtr Native => _native;

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

        public AvifImagePlanes<byte> YUVPlanes8 => new AvifImagePlanes<byte>(_native);
        public AvifImagePlanes<ushort> YUVPlanes16 => new AvifImagePlanes<ushort>(_native);

        public bool ImageOwnsYUVPlanes
        {
            get { unsafe { return Get(p => p->imageOwnsYUVPlanes) != 0; } }
            set { unsafe { Set((p, v) => p->imageOwnsYUVPlanes = v ? 1 : 0, value); } }
        }

        public AvifRange AlphaRange
        {
            get { unsafe { return (AvifRange)Get(p => p->alphaRange); } }
            set { unsafe { Set((p, v) => p->alphaRange = v, (avifRange)value); } }
        }

        private AvifImageData<T> GetAlphaPlane<T>() where T : unmanaged
        {
            unsafe
            {
                if (_native == IntPtr.Zero)
                {
                    return default;
                }
                var p = (avifImage*)_native;
                return new AvifImageData<T>(1, p->width, p->height, p->alphaPlane, p->alphaRowBytes);
            }
        }

        public AvifImageData<byte> AlphaPlane8 => GetAlphaPlane<byte>();
        public AvifImageData<ushort> AlphaPlane16 => GetAlphaPlane<ushort>();

        public bool ImageOwnsAlphaPlane
        {
            get { unsafe { return Get(p => p->imageOwnsAlphaPlane) != 0; } }
            set { unsafe { Set((p, v) => p->imageOwnsAlphaPlane = v, value ? 1 : 0); } }
        }

        public bool AlphaPremultiplied
        {
            get { unsafe { return Get(p => p->alphaPremultiplied) != 0; } }
            set { unsafe { Set((p, v) => p->alphaPremultiplied = v, value ? 1 : 0); } }
        }

        public AvifData<byte> ICC
        {
            get { unsafe { return new AvifData<byte>(Get(p => p->icc)); } }
        }

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

        public AvifTransformationFlags TransformFlags
        {
            get { unsafe { return (AvifTransformationFlags)Get(p => p->transformFlags); } }
            set { unsafe { Set((p, v) => p->transformFlags = v, (uint)value); } }
        }

        public AvifPixelAspectRatioBox PixelAspectRatio
        {
            get { unsafe { return AvifPixelAspectRatioBox.From(Get(p => p->pasp)); } }
            set { unsafe { Set((p, v) => p->pasp = v.To(), value); } }
        }

        public AvifCleanApertureBox CleanAperture
        {
            get { unsafe { return AvifCleanApertureBox.From(Get(p => p->clap)); } }
            set { unsafe { Set((p, v) => p->clap = v.To(), value); } }
        }

        public byte ImageRotationAngle
        {
            get { unsafe { return Get(p => p->irot.angle); } }
            set { unsafe { Set((p, v) => p->irot = new avifImageRotation() { angle = v }, value); } }
        }

        public byte ImageMirrorAxis
        {
            get { unsafe { return Get(p => p->imir.axis); } }
            set { unsafe { Set((p, v) => p->imir = new avifImageMirror() { axis = v }, value); } }
        }

        public AvifData<byte> Exif
        {
            get { unsafe { return new AvifData<byte>(Get(p => p->exif)); } }
        }

        public AvifData<byte> XMP
        {
            get { unsafe { return new AvifData<byte>(Get(p => p->xmp)); } }
        }

        public bool IsUsesU16
        {
            get { unsafe { return Get(p => libavif.avifImageUsesU16(new IntPtr(p))) != 0; } }
        }

        public void AllocatePlanes(AvifPlanesFlags planes)
        {
            if (_native != IntPtr.Zero)
            {
                libavif.avifImageAllocatePlanes(_native, (uint)planes);
            }
        }

        public void FreePlanes(AvifPlanesFlags planes)
        {
            if (_native != IntPtr.Zero)
            {
                libavif.avifImageFreePlanes(_native, (uint)planes);
            }
        }

        public void CopyTo(AvifImage dstImage, AvifPlanesFlags planes)
        {
            if (_native != IntPtr.Zero && dstImage._native != IntPtr.Zero)
            {
                libavif.avifImageCopy(dstImage._native, _native, (uint)planes);
            }
        }

        public void StealPlanes(AvifImage dstImage, AvifPlanesFlags planes)
        {
            if (_native != IntPtr.Zero && dstImage._native != IntPtr.Zero)
            {
                libavif.avifImageStealPlanes(dstImage._native, _native, (uint)planes);
            }
        }

        public void SetProfileICC(byte[] icc)
        {
            unsafe
            {
                if (_native != IntPtr.Zero)
                {
                    fixed (byte* p = &icc[0])
                    {
                        libavif.avifImageSetProfileICC(_native, p, (ulong)icc.Length);
                    }
                }
            }
        }

        public void SetMetadataExif(byte[] exif)
        {
            unsafe
            {
                if (_native != IntPtr.Zero)
                {
                    fixed (byte* p = &exif[0])
                    {
                        libavif.avifImageSetMetadataExif(_native, p, (ulong)exif.Length);
                    }
                }
            }
        }

        public void SetMetadataXMP(byte[] xmp)
        {
            unsafe
            {
                if (_native != IntPtr.Zero)
                {
                    fixed (byte* p = &xmp[0])
                    {
                        libavif.avifImageSetMetadataXMP(_native, p, (ulong)xmp.Length);
                    }
                }
            }
        }

        public AvifRGBImage ConvertToRGB()
        {
            var ret = AvifRGBImage.Create(this);
            try
            {
                ConvertToRGB(ret);
                return ret;
            }
            catch
            {
                ret.Dispose();
                throw;
            }
        }

        public void ConvertToRGB(AvifRGBImage dst)
        {
            unsafe
            {
                fixed (avifRGBImage* p = &dst._native)
                {
                    AvifException.ThrowExceptionForResult((AvifResult)libavif.avifImageYUVToRGB(Native, new IntPtr(p)));
                }
            }
        }
    }
}
