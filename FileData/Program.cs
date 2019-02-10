using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var fileDetails = new FileDetails();
            try
            {
                if (args != null)
                {


                    if (args.Length == 2)
                    {
                        FileAction fileAction = new FileAction(
                             new VersionProperty(fileDetails),
                             new SizeProperty(fileDetails),
                             new DataGenerator()
                            );

                        var response = fileAction.PerformAction(args[0], args[1]);
                        Console.WriteLine(response);
                    }
                    else
                        throw new ArgumentNullException($"{args} is not found");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

     
    }
}
