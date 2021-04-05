using System;
using System.Collections.Generic;
using System.Text;

namespace LibAvif
{
    public readonly ref struct AvifImageData<T> where T : unmanaged
    {
        private readonly AvifData<byte> _data;

        public AvifImageData(uint channelCount, uint width, uint height, IntPtr p, uint rowBytes)
        {
            ChannelCount = channelCount;
            Width = width;
            Height = height;
            RowBytes = rowBytes;
            _data = new AvifData<byte>(p, height * rowBytes);
        }

        unsafe public IntPtr Pointer => _data.Pointer;

        public uint ChannelCount { get; }
        public uint Width { get; }
        public uint Height { get; }
        public uint RowBytes { get; }

        public AvifData<T> this[uint y]
        {
            get
            {
                if (y >= Height)
                {
                    throw new ArgumentOutOfRangeException();
                }
                unsafe
                {
                    return new AvifData<T>(new IntPtr((byte*)_data.Pointer + RowBytes * y), Width * ChannelCount);
                }
            }
        }
    }
}
