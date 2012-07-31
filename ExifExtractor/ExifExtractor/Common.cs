using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifExtractor
{
    public enum FileTypeEnum
    {
        Unknown,
        JPEG,
        TIFF, // Vendor-agnostic RAW format
        CR2, // Canon proprietary RAW format
        NEF, // Nikon proprietary RAW format
        DNG, // Adobe open RAW format ("Digital Negative")
    }

    public enum ImageType
    {
        Thumbnail,
        Fullsize
    } 
}
