using System;
using System.Collections.Generic;
using System.Text;
using LibAvif.Binding;

namespace LibAvif
{
    public sealed class AvifRWData : IDisposable
    {
        private bool _disposedValue;
        internal avifRWData _native;

        internal AvifRWData()
        {
        }

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                unsafe
                {
                    if (_native.data != IntPtr.Zero)
                    {
                        fixed (avifRWData* p = &_native)
                        {
                            libavif.avifRWDataFree(new IntPtr(p));
                        }
                    }
                }

                _disposedValue = true;
            }
        }

        ~AvifRWData()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public IntPtr Data => _native.data;
        public ulong Size => _native.size;
    }
}
