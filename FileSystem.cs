using System;
using System.IO;

namespace cmd_V2
{
    class FileSystem
    {
        //Get Directories:
        public string[] getDirectories(string dir)
        {
            string[] dirs = Directory.GetDirectories(dir);
            return dirs;
        }

        //Get Files:
        public string[] getFiles(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            return files;
        }

        //File Exists:
        public bool fileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }

            return false;
        }

        //Directory Exists:
        public bool dirExists(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }

            return false;
        }

        //Create File:
        public void createFile(string path)
        {
            File.Create(path);
        }

        //Read:
        public string read(string path)
        {
            string contents = "";
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                contents = contents + sr.ReadLine() + "\n";
            }

            return contents;
        }

        //Get Root:
        public string getRoot()
        {
            string root = Path.GetPathRoot(Directory.GetCurrentDirectory());
            return root;
        }
    }
}