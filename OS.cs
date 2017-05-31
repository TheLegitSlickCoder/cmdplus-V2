using System;
using System.Diagnostics;

namespace cmd_V2
{
    class OS
    {
        FileSystem fs = new FileSystem();

        //Kill Process:
        public void killProcess(string name)
        {
            foreach (var process in Process.GetProcessesByName(name))
            {
                process.Kill();
            }
        }

        //Get Users:
        public string[] getUsers()
        {
            string root = fs.getRoot();
            string usrPath = root + "Users";
            string[] users = fs.getDirectories(usrPath);
            return users;
        }
    }
}