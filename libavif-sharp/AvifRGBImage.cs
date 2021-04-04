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


    public sealed class AvifRGBImage : IDisposable
    {
        private avifRGBImage _native;

        public AvifRGBImage()
        {
        }

        public void Dispose()
        {
            
        }

        public uint Width
        {
            get => _native.width;
            set => _native.width = value;
        }

        public uint Height
        {
            get => _native.height;
            set => _native.height = value;
        }

        public uint Depth
        {
            get => _native.depth;
            set => _native.depth = value;
        }

        public AvifRGBFormat Format
        {
            get => (AvifRGBFormat)_native.format;
            set => _native.format = (avifRGBFormat)value;
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

        public AvifImageData<byte> Pixels8 => new AvifImageData<byte>(Format.GetChannelCount(), _native.width, _native.height, _native.pixels, _native.rowBytes);
        public AvifImageData<ushort> Pixels16 => new AvifImageData<ushort>(Format.GetChannelCount(), _native.width, _native.height, _native.pixels, _native.rowBytes);
    }
}
