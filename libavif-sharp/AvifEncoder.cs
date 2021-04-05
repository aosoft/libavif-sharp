using System;
using LibAvif.Binding;

namespace LibAvif
{
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
    }
}
