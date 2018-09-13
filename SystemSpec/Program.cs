using System;

namespace SystemSpec
{
    class Program
    {
        static int Main(string[] args)
        {
            ShowEnvironmentDetails();

            Console.ReadLine();
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);

            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);

            Console.WriteLine(".NET Version: {0}", Environment.Version);

            Console.WriteLine("Username: {0}", Environment.UserName);

            Console.WriteLine("MachineName: {0}", Environment.MachineName);

            Console.WriteLine("OS 64x?: {0}", Environment.Is64BitOperatingSystem);
        }
    }
}
