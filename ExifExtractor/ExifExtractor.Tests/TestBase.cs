using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExifExtractor.Tests
{
    public class TestBase
    {
        private const string TEST_DATA_PATH = @"D:\VCS\GIT\ExifExtractor\ExifExtractor\Resources";

        protected string GetPath(string fileName)
        {
            return System.IO.Path.Combine(TEST_DATA_PATH, fileName);
        }
    }
}
