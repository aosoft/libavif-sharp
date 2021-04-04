using System;
using LibAvif.Binding;

namespace LibAvif
{
    public readonly ref struct AvifData<T> where T : unmanaged
    {
        private readonly IntPtr _p;
        private readonly ulong _count;

        public AvifData(IntPtr p, ulong count)
        {
            _p = p;
            _count = count;
        }

        internal AvifData(avifRWData data)
        {
            unsafe
            {
                _p = data.data;
                _count = data.size / (ulong)sizeof(T);
            }
        }

        unsafe public IntPtr Pointer => _p;

        public ulong Count => _count;

        public T this[ulong index]
        {
            get
            {
                if (index >= _count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                unsafe
                {
                    return *(((T*)_p) + index);
                }
            }

            set
            {
                if (index >= _count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                unsafe
                {
                   *(((T*)_p) + index) = value;
                }
            }
        }
    }

    public readonly ref struct AvifReadOnlyData<T> where T : unmanaged
    {
        private readonly AvifData<T> _data;

        public AvifReadOnlyData(IntPtr p, ulong count)
        {
            _data = new AvifData<T>(p, count);
        }

        internal AvifReadOnlyData(avifROData data)
        {
            unsafe
            {
                _data = new AvifData<T>(data.data, data.size / (ulong)sizeof(T));
            }
        }


        unsafe public IntPtr Pointer => _data.Pointer;

        public ulong Count => _data.Count;

        public T this[ulong index] => _data[index];
    }
}
