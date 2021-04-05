using System;
using LibAvif.Binding;

namespace LibAvif
{
    public readonly struct AvifIOStats
    {
        public ulong ColorOBUSize { get; }
        public ulong AlphaOBUSize { get; }

        public AvifIOStats(ulong colorOBUSize, ulong alphaOBUSize)
        {
            ColorOBUSize = colorOBUSize;
            AlphaOBUSize = alphaOBUSize;
        }

        internal static AvifIOStats From(avifIOStats src) => new AvifIOStats(src.colorOBUSize, src.alphaOBUSize);
        internal avifIOStats To() => new avifIOStats() { colorOBUSize = ColorOBUSize, alphaOBUSize = AlphaOBUSize };
    }


    public sealed class AvifEncoder : IDisposable
    {
        private bool _disposedValue;
        private IntPtr _native;

        public AvifEncoder()
        {
            _native = libavif.avifEncoderCreate();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                libavif.avifEncoderDestroy(_native);
                _native = IntPtr.Zero;
                _disposedValue = true;
            }
        }

        ~AvifEncoder()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        unsafe private delegate T FnGet<T>(avifEncoder* p);
        unsafe private delegate void FnSet<T>(avifEncoder* p, T value);

        unsafe private T Get<T>(FnGet<T> fn)
        {
            return _native != IntPtr.Zero ? fn((avifEncoder*)_native) : default(T);
        }
        unsafe private void Set<T>(FnSet<T> fn, T value)
        {
            if (_native != IntPtr.Zero)
            {
                fn((avifEncoder*)_native, value);
            }
        }

        public AvifCodecChoice CodecChoice
        {
            get { unsafe { return (AvifCodecChoice)Get(p => p->codecChoice); } }
            set { unsafe { Set((p, v) => p->codecChoice = v, (avifCodecChoice)value); } }
        }

        public int MaxThreads
        {
            get { unsafe { return Get(p => p->maxThreads); } }
            set { unsafe { Set((p, v) => p->maxThreads = v, value); } }
        }

        public int MinQuantizer
        {
            get { unsafe { return Get(p => p->minQuantizer); } }
            set { unsafe { Set((p, v) => p->minQuantizer = v, value); } }
        }

        public int MaxQuantizer
        {
            get { unsafe { return Get(p => p->maxQuantizer); } }
            set { unsafe { Set((p, v) => p->maxQuantizer = v, value); } }
        }

        public int MinQuantizerAlpha
        {
            get { unsafe { return Get(p => p->minQuantizerAlpha); } }
            set { unsafe { Set((p, v) => p->minQuantizerAlpha = v, value); } }
        }

        public int MaxQuantizerAlpha
        {
            get { unsafe { return Get(p => p->maxQuantizerAlpha); } }
            set { unsafe { Set((p, v) => p->maxQuantizerAlpha = v, value); } }
        }

        public int TileRowsLog2
        {
            get { unsafe { return Get(p => p->tileRowsLog2); } }
            set { unsafe { Set((p, v) => p->tileRowsLog2 = v, value); } }
        }

        public int TileColsLog2
        {
            get { unsafe { return Get(p => p->tileColsLog2); } }
            set { unsafe { Set((p, v) => p->tileColsLog2 = v, value); } }
        }

        public int Speed
        {
            get { unsafe { return Get(p => p->speed); } }
            set { unsafe { Set((p, v) => p->speed = v, value); } }
        }

        public int KeyframeInterval
        {
            get { unsafe { return Get(p => p->keyframeInterval); } }
            set { unsafe { Set((p, v) => p->keyframeInterval = v, value); } }
        }

        public ulong Timescale
        {
            get { unsafe { return Get(p => p->timescale); } }
            set { unsafe { Set((p, v) => p->timescale = v, value); } }
        }

        public AvifIOStats IOStats
        {
            get { unsafe { return AvifIOStats.From(Get(p => p->ioStats)); } }
            set { unsafe { Set((p, v) => p->ioStats = v.To(), value); } }
        }
    }
}
