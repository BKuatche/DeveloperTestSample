using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
     public class DataGenerator
    {

         public readonly List<string> VersionGenrator = new List<string>()
        {
            "-v",
            "–v",
            "--v",
            "/v",
            "--version"
        };


        public readonly List<string> SizeGenerator = new List<string>()
        {
            "-s",
            "–s",
            "--s",
            "/s",
            "--size"
        };
    }
}
