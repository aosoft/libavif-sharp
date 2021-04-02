using System;
using System.Collections.Generic;
using System.Text;
using LibAvif.Binding;

namespace LibAvif
{
    public enum AvifResult
    {
        Ok = avifResult.AVIF_RESULT_OK,
        UknownError = avifResult.AVIF_RESULT_UNKNOWN_ERROR,
        InvalidFtyp = avifResult.AVIF_RESULT_INVALID_FTYP,
        NoContent = avifResult.AVIF_RESULT_NO_CONTENT,
        NoYUVFormatSelcted = avifResult.AVIF_RESULT_NO_YUV_FORMAT_SELECTED,
        ReformatFailed = avifResult.AVIF_RESULT_REFORMAT_FAILED,
        UnSupportedDepth = avifResult.AVIF_RESULT_UNSUPPORTED_DEPTH,
        EncodeColorFailed = avifResult.AVIF_RESULT_ENCODE_COLOR_FAILED,
        EncodeAlphaFailed = avifResult.AVIF_RESULT_ENCODE_ALPHA_FAILED,
        BMFFParseFailed = avifResult.AVIF_RESULT_BMFF_PARSE_FAILED,
        NoAV1ItemsFound = avifResult.AVIF_RESULT_NO_AV1ITEMS_FOUND,
        DecodeColorFailed = avifResult.AVIF_RESULT_DECODE_COLOR_FAILED,
        DecodeAlphaFaield = avifResult.AVIF_RESULT_DECODE_ALPHA_FAILED,
        ColorAlphaSizeMismatch = avifResult.AVIF_RESULT_COLOR_ALPHA_SIZE_MISMATCH,
        ISPESizeMismatch = avifResult.AVIF_RESULT_ISPE_SIZE_MISMATCH,
        NoCodecAvailable = avifResult.AVIF_RESULT_NO_CODEC_AVAILABLE,
        NoImagesRemaining = avifResult.AVIF_RESULT_NO_IMAGES_REMAINING,
        InvalidExifPayload = avifResult.AVIF_RESULT_INVALID_EXIF_PAYLOAD,
        InvalidImageGrid = avifResult.AVIF_RESULT_INVALID_IMAGE_GRID,
        InvalidCodecSpecificOption = avifResult.AVIF_RESULT_INVALID_CODEC_SPECIFIC_OPTION,
        TruncatedData = avifResult.AVIF_RESULT_TRUNCATED_DATA,
        IONotSet = avifResult.AVIF_RESULT_IO_NOT_SET,
        IOError = avifResult.AVIF_RESULT_IO_ERROR,
        WaitingOnIO = avifResult.AVIF_RESULT_WAITING_ON_IO,
        InvalidArgument = avifResult.AVIF_RESULT_INVALID_ARGUMENT,
        NotImplemented = avifResult.AVIF_RESULT_NOT_IMPLEMENTED,
    }

    public class AvifException : Exception
    {
        public AvifResult Result { get; }

        public AvifException(AvifResult r) : base(r.ToString())
        {
            Result = r;
        }
    }
}
