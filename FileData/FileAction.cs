using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileAction
    {
        private readonly VersionProperty versionProperty;
        private readonly SizeProperty sizeProperty;
        private readonly DataGenerator dataGenerator;
        private Random random = new Random();

        public FileAction(VersionProperty versionProperty, SizeProperty sizeProperty, DataGenerator dataGenerator)
        {
            this.versionProperty = versionProperty;
            this.sizeProperty = sizeProperty;
            this.dataGenerator = dataGenerator;
        }

        public string PerformAction(string data, string filename)
        {
            IFile file = null;

            if (dataGenerator.SizeGenerator.Contains(data))
            {
                file = sizeProperty;
            }
            else if (dataGenerator.VersionGenrator.Contains(data))
            {
                file = versionProperty;
            }
            else
            {
                throw new Exception($"No Such Data with {data} Present");
            }

            return file.Actions(filename);
        }


        public string GetRandomVersion()
        {
            int count= random.Next(0, dataGenerator.VersionGenrator.Count());
            return dataGenerator.VersionGenrator[count];
        }


        public string GetRandomSize()
        {
            int count = random.Next(0, dataGenerator.SizeGenerator.Count());
            return dataGenerator.SizeGenerator[count];
        }





    }
}
