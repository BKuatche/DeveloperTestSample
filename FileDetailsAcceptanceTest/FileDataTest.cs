using System;
using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace FileDetailsAcceptanceTest
{
    [TestClass]
    public class FileDataTest
    {
        private readonly FileDetails fileDetails = new FileDetails();

        [TestMethod]
        public void TestVersion()
        {       
            FileAction fileAction = new FileAction(
                new VersionProperty(fileDetails),
                new SizeProperty(fileDetails),
                new DataGenerator()
                );

            var randomVersion = fileAction.GetRandomVersion();
            var version = fileAction.PerformAction(randomVersion, "C:/file.txt");
            Assert.IsTrue(version.Contains("."));
        }

        [TestMethod]
        public void TestSize()
        {
            FileAction fileAction = new FileAction(
                new VersionProperty(fileDetails),
                new SizeProperty(fileDetails),
                new DataGenerator()
                );

            var randomVersion = fileAction.GetRandomSize();
            var size = fileAction.PerformAction(randomVersion, "C:/file.txt");
            Assert.IsFalse(size.Contains("."));
        }

        [TestMethod]
        public void NegativeVersionTest()
        {
            FileAction fileAction = new FileAction(
               new VersionProperty(fileDetails),
               new SizeProperty(fileDetails),
               new DataGenerator()
               );
            try
            {
               fileAction.PerformAction("vsvs", "C:/file.txt");
                
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "No Such Data with vsvs Present");
                
            }
                    
        }


        [TestMethod]
        public void NegativeSizeTest()
        {
            FileAction fileAction = new FileAction(
                      new VersionProperty(fileDetails),
                      new SizeProperty(fileDetails),
                      new DataGenerator()
                      );
            try
            {
                fileAction.PerformAction("ss", "C:/file.txt");
            }
            catch (Exception e)
            {

                Assert.AreEqual(e.Message, "No Such Data with ss Present");
            }
            
           
        }
    }
}
