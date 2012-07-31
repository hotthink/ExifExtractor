using System;
using System.IO;

namespace ExifExtractor.Tests
{
    public class ExifReader
    {

        
        public abstract class ExifFile
        {
            public FileTypeEnum FileType { get; private set; }

            protected ExifFile(FileTypeEnum fileType)
            {
                FileType = fileType;
            }
        }

        public class ExifFileJpeg : ExifFile
        {
            internal ExifFileJpeg(string fileName) : base(FileTypeEnum.JPEG)
            {
            }
        }

        public ExifFile Open(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException("File not found",fileName);

            string fileExtension = Path.GetExtension(fileName);
            if(string.IsNullOrEmpty(fileExtension))
                throw new FormatException("Unable to determine file type from file name");

            switch (fileExtension.ToLower())
            {
                case ".jpg":
                case ".jpeg":
                    return new ExifFileJpeg(fileName);

                case ".dng":
                case ".tif":
                case ".tiff":
                case ".cr2":
                case ".nef":
                    throw new NotImplementedException("This extension not yet supported");

                default:
                    throw new NotSupportedException("File extension '' is not supported");
            }
            return null;
        }
    }
}