using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExifExtractor.Tests
{
    public class IdentifyFileTypeTests : TestBase
    {            
        private void IdentifyFileType(string testPath, FileTypeEnum expectedType)
        {
            testPath = GetPath(testPath);

            var reader = new ExifReader();
            var file = reader.Open(testPath);

            Assert.True(file.FileType == expectedType);
        }

        [Fact]
        public void IdentifyTiff()
        {
            IdentifyFileType("example.tif", FileTypeEnum.TIFF);
        }

        [Fact]
        public void IdentifyJpeg()
        {
            IdentifyFileType("example.jpg", FileTypeEnum.JPEG);
        }

        [Fact]
        public void IdentifyCanonCr2()
        {
            IdentifyFileType("example.cr2", FileTypeEnum.CR2);
        }

        [Fact]
        public void IdentifyNikonNek()
        {
            IdentifyFileType("example.nef", FileTypeEnum.NEF);
        }

        [Fact]
        public void IdentifyDng()
        {
            IdentifyFileType("example.dng", FileTypeEnum.DNG);
        }
    }
}
