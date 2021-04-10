using System;
using LibAvif.Binding;

namespace LibAvif
{
    public enum AvifDecoderSource
    {
        Auto = avifDecoderSource.AVIF_DECODER_SOURCE_AUTO,
        PrimaryItem = avifDecoderSource.AVIF_DECODER_SOURCE_PRIMARY_ITEM,
        Tracks = avifDecoderSource.AVIF_DECODER_SOURCE_TRACKS,
    }


    public sealed class AvifDecoder : IDisposable
    {
        private bool _disposedValue;
        private IntPtr _native;

        public AvifDecoder()
        {
            _native = libavif.avifDecoderCreate();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (_native != IntPtr.Zero)
                {
                    libavif.avifDecoderDestroy(_native);
                    _native = IntPtr.Zero;
                }
                _disposedValue = true;
            }
        }

        ~AvifDecoder()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        unsafe private delegate T FnGet<T>(avifDecoder* p);
        unsafe private delegate void FnSet<T>(avifDecoder* p, T value);

        unsafe private T Get<T>(FnGet<T> fn)
        {
            return _native != IntPtr.Zero ? fn((avifDecoder*)_native) : default(T);
        }
        unsafe private void Set<T>(FnSet<T> fn, T value)
        {
            if (_native != IntPtr.Zero)
            {
                fn((avifDecoder*)_native, value);
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

        public AvifDecoderSource RequestedSource
        {
            get { unsafe { return (AvifDecoderSource)Get(p => p->requestedSource); } }
        }

        public int ImageIndex
        {
            get { unsafe { return Get(p => p->imageIndex); } }
        }

        public int ImageCount
        {
            get { unsafe { return Get(p => p->imageCount); } }
        }

        public ulong Timescale
        {
            get { unsafe { return Get(p => p->timescale); } }
        }

        public double Duration
        {
            get { unsafe { return Get(p => p->duration); } }
        }

        public ulong DurationInTimescales
        {
            get { unsafe { return Get(p => p->durationInTimescales); } }
        }

        public int AlphaPresent
        {
            get { unsafe { return Get(p => p->alphaPresent); } }
            set { unsafe { Set((p, v) => p->alphaPresent = v, value); } }
        }

        public int IgnoreExif
        {
            get { unsafe { return Get(p => p->ignoreExif); } }
            set { unsafe { Set((p, v) => p->ignoreExif = v, value); } }
        }

        public int IgnoreXMP
        {
            get { unsafe { return Get(p => p->ignoreXMP); } }
            set { unsafe { Set((p, v) => p->ignoreXMP = v, value); } }
        }

        public uint ImageCountLimit
        {
            get { unsafe { return Get(p => p->imageCountLimit); } }
            set { unsafe { Set((p, v) => p->imageCountLimit = v, value); } }
        }

        public void SetSource(AvifDecoderSource source)
        {
            if (_native != IntPtr.Zero)
            {
                libavif.avifDecoderSetSource(_native, (avifDecoderSource)source);
            }
        }

        public AvifImage ReadMemory(byte[] memory)
        {
            if (_native != IntPtr.Zero)
            {
                var ret = new AvifImage();
                try
                {
                    unsafe
                    {
                        fixed (byte* p = &memory[0])
                        {
                            AvifException.ThrowExceptionForResult((AvifResult)libavif.avifDecoderReadMemory(_native, ret.Native, p, (ulong)memory.Length));
                        }
                    }
                    return ret;
                }
                catch
                {
                    ret.Dispose();
                    throw;
                }
            }
            return null;
        }

        public AvifImage ReadMemory(AvifReadOnlyData<byte> memory)
        {
            if (_native != IntPtr.Zero)
            {
                var ret = new AvifImage();
                try
                {
                    unsafe
                    {
                        AvifException.ThrowExceptionForResult((AvifResult)libavif.avifDecoderReadMemory(_native, ret.Native, (byte*)memory.Pointer.ToPointer(), memory.Count));
                    }
                    return ret;
                }
                catch
                {
                    ret.Dispose();
                    throw;
                }
            }
            return null;
        }

        public AvifImage ReadMemory(AvifRWData data) => ReadMemory(data.GetReadOnlyData<byte>());
    }
}
