using System;
using System.Diagnostics;

namespace cmd_V2
{
    class Launcher
    {
        //Launch:
        public void launch(string path)
        {
            Process.Start(path);
        }
    }
}