using System;
using LibAvif.Binding;
using LibAvif.Extensions;

namespace LibAvif
{
    public enum AvifRGBFormat
    {
        RGB = avifRGBFormat.AVIF_RGB_FORMAT_RGB,
        RGBA = avifRGBFormat.AVIF_RGB_FORMAT_RGBA,
        ARGB = avifRGBFormat.AVIF_RGB_FORMAT_ARGB,
        BGR = avifRGBFormat.AVIF_RGB_FORMAT_BGR,
        BGRA = avifRGBFormat.AVIF_RGB_FORMAT_BGRA,
        ABGR = avifRGBFormat.AVIF_RGB_FORMAT_ABGR,
    }

    public enum AvifChromaUpsampling
    {
        Automatic = avifChromaUpsampling.AVIF_CHROMA_UPSAMPLING_AUTOMATIC,
        Fastest = avifChromaUpsampling.AVIF_CHROMA_UPSAMPLING_FASTEST,
        BestQuality = avifChromaUpsampling.AVIF_CHROMA_UPSAMPLING_BEST_QUALITY,
        Nearest = avifChromaUpsampling.AVIF_CHROMA_UPSAMPLING_NEAREST,
        Bilinear = avifChromaUpsampling.AVIF_CHROMA_UPSAMPLING_BILINEAR,
    }


    public class AvifRGBImageView
    {
        internal avifRGBImage _native;

        internal AvifRGBImageView()
        {
        }

        public AvifRGBImageView(uint width, uint height, uint depth, AvifRGBFormat format, IntPtr pixels, uint rowBytes)
        {
            _native.width = width;
            _native.height = height;
            _native.depth = depth;
            _native.format = (avifRGBFormat)format;
            _native.pixels = pixels;
            _native.rowBytes = rowBytes;
        }

        public uint Width
        {
            get => _native.width;
        }

        public uint Height
        {
            get => _native.height;
        }

        public uint Depth
        {
            get => _native.depth;
        }

        public AvifRGBFormat Format
        {
            get => (AvifRGBFormat)_native.format;
        }

        public AvifChromaUpsampling ChromaUpsampling
        {
            get => (AvifChromaUpsampling)_native.chromaUpsampling;
            set => _native.chromaUpsampling = (avifChromaUpsampling)value;
        }

        public bool IgnoreAlpha
        {
            get => _native.ignoreAlpha != 0;
            set => _native.ignoreAlpha = value ? 1 : 0;
        }

        public bool AlphaPremultiplied
        {
            get => _native.alphaPremultiplied != 0;
            set => _native.alphaPremultiplied = value ? 1 : 0;
        }

        public uint PixelSize
        {
            get
            {
                unsafe
                {
                    fixed (avifRGBImage* p = &_native)
                    {
                        return libavif.avifRGBImagePixelSize(new IntPtr(p));
                    }
                }
            }
        }

        public uint BytePerChannel => Depth > 8 ? 2u : 1u;

        public AvifImageData<byte> Pixels8 => new AvifImageData<byte>(Format.GetChannelCount(), _native.width, _native.height, _native.pixels, _native.rowBytes);
        public AvifImageData<ushort> Pixels16 => new AvifImageData<ushort>(Format.GetChannelCount(), _native.width, _native.height, _native.pixels, _native.rowBytes);

        public void PremultiplyAlpha()
        {
            unsafe
            {
                fixed (avifRGBImage* p = &_native)
                {
                    libavif.avifRGBImagePremultiplyAlpha(new IntPtr(p));
                }
            }
        }

        public void UnpremultiplyAlpha()
        {
            unsafe
            {
                fixed (avifRGBImage* p = &_native)
                {
                    libavif.avifRGBImageUnpremultiplyAlpha(new IntPtr(p));
                }
            }
        }

        public AvifImage ConvertToYUV(
            AvifPixelFormat format,
            AvifRange yuvRange,
            AvifColorPrimaries colorPrimaries,
            AvifTransferCharacteristics transferCharacteristics,
            AvifMatrixCoefficients matrixCoefficients)
        {
            unsafe
            {
                var ret = new AvifImage();
                try
                {
                    ret.Width = Width;
                    ret.Height = Height;
                    ret.Depth = Depth;
                    ret.YUVFormat = format;
                    ret.YUVRange = yuvRange;
                    ret.ColorPrimaries = colorPrimaries;
                    ret.TransferCharacteristics = transferCharacteristics;
                    ret.MatrixCoefficients = matrixCoefficients;
                    ConvertToYUV(ret);
                    return ret;
                }
                catch
                {
                    ret.Dispose();
                    throw;
                }
            }
        }

        public void ConvertToYUV(AvifImage image)
        {
            unsafe
            {
                fixed (avifRGBImage* p = &_native)
                {
                    AvifException.ThrowExceptionForResult((AvifResult)libavif.avifImageRGBToYUV(image.Native, new IntPtr(p)));
                }
            }
        }
    }

    public sealed class AvifRGBImage : AvifRGBImageView, IDisposable
    {
        private bool _disposedValue;

        internal AvifRGBImage()
        {
        }

        internal AvifRGBImage(uint width, uint height, uint depth, AvifRGBFormat format, IntPtr pixels, uint rowBytes) : base(width, height, depth, format, pixels, rowBytes)
        {
        }

        public static AvifRGBImage Create(uint width, uint height, uint depth, AvifRGBFormat format)
        {
            var ret = new AvifRGBImage(width, height, depth, format, IntPtr.Zero, 0);

            unsafe
            {
                fixed (avifRGBImage* p = &ret._native)
                {
                    libavif.avifRGBImageAllocatePixels(new IntPtr(p));
                }
            }

            return ret;
        }

        public static AvifRGBImage Create(AvifImage def)
        {
            var ret = new AvifRGBImage();

            unsafe
            {
                fixed (avifRGBImage* p = &ret._native)
                {
                    libavif.avifRGBImageSetDefaults(new IntPtr(p), def.Native);
                    libavif.avifRGBImageAllocatePixels(new IntPtr(p));
                }
            }

            return ret;
        }

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                unsafe
                {
                    fixed (avifRGBImage* p = &_native)
                    {
                        libavif.avifRGBImageFreePixels(new IntPtr(p));
                    }
                }
                _disposedValue = true;
            }
        }

        ~AvifRGBImage()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
