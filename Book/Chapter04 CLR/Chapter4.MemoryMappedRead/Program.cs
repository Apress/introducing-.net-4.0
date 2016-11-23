using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace Chapter4.MemoryMappedRead
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MemoryMappedFile MemoryMappedFile = MemoryMappedFile.OpenExisting("test"))
            {
                using (MemoryMappedViewStream Stream = MemoryMappedFile.CreateViewStream())
                {
                    BinaryReader reader = new BinaryReader(Stream);
                    Console.WriteLine(reader.ReadString());
                }
                Console.ReadKey();
            }
        }
    }
}
