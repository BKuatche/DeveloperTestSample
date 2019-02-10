using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class VersionProperty:IFile
    {

        FileDetails _fileDetails { get; set; }

        public VersionProperty(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }

       

        public string Actions(string filepath)
        {
            return _fileDetails.Version(filepath).ToString();
        }
    }
}
