﻿using System.IO;

namespace CommonHelper
{
    public class FileHelper
    {
        public static void CreatePath(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                Console.WriteLine("Path already exists::" + path);
            }
        }

        public static bool CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.CreateNew))
                {
                }
            }
            else
            {
                Console.WriteLine("File already exists::" + fileName);
            }
            return true;
        }


    }
}
