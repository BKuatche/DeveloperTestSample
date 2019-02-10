using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
   public class SizeProperty:IFile
    {
        FileDetails _fileDetails { get; set; }

        public SizeProperty(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }


        public string Actions(string filepath)
        {
            return _fileDetails.Size(filepath).ToString();
        }
    }
}
