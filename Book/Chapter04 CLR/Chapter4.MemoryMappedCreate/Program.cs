using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace Chapter4.MemoryMappedCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MemoryMappedFile MemoryMappedFile = MemoryMappedFile.CreateNew("test", 100))
            {
                MemoryMappedViewStream stream = MemoryMappedFile.CreateViewStream();
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write("hello memory mapped file!");
                }
                Console.WriteLine("Press any key to close mapped file");
                Console.ReadKey();
            }
        }
    }
}
