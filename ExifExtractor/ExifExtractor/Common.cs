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
        CR2, // Canon proprietary RAW format
        NEF, // Nikon proprietary RAW format
        DNG, // Adobe open RAW format ("Digital Negative")
    }
     
}
