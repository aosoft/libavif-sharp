libavif-sharp
=====

[LICENSE (BSD)](LICENSE)

C# Binding Library for libavif

## How to use

You need the dynamic link library (avif.dll) of libavif to use it.

```csharp
using LibAvif;

using var rgb = AvifRGBImage.Create(1024, 1024, 8, AvifRGBFormat.RGB);

// Draw an image for AvifRGBImage.Pixels8 or Pixels16

using var yuv = rgb.ConvertToYUV(
    AvifPixelFormat.YUV444,
    AvifRange.Full,
    AvifColorPrimaries.BT709,
    AvifTransferCharacteristics.sRGB,
    AvifMatrixCoefficients.BT709);
using var encoder = new AvifEncoder();
using var encoded = encoder.Write(yuv);
```


