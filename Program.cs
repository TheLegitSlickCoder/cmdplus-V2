using System;

namespace cmd_V2
{
    class Program
    {
        //Class Imports:
        static FileSystem fs = new FileSystem();
        static Launcher launcher = new Launcher();
        static Client client = new Client();
        static NumberGen numgen = new NumberGen();
        static OS os = new OS();

        //Main void:
        static void Main(string[] args)
        {
            //If no arguments are passed into the program.
            if (args.Length < 1)
            {
                return;
            }

            //Help Command:
            if (args[0] == "help")
            {
                print("help: Displays all cmd+ commands.");
                print("getdirs (path): Displays the subdirectories in a directory.");
                print("getfiles (path): Displays the subfiles in a directory.");
                print("checkfile (path): Checks if a file exists.");
                print("checkdir (path): Checks if a directory exists.");
                print("createfile (path): Creates a file.");
                print("read (path): Displays the contents in a file.");
                print("launch (string): Opens a file, folder, or URL.");
                print("getsrc (URL): Returns the HTML source of a webpage.");
                print("resolve (URL): Resolves the IP of a hostname.");
                print("print (string): Prints a string into the console.");
                print("clear: Clears the console.");
                print("date: Displays the date and time.");
                print("rand: Displays a random integer.");
                print("killproc (process): Kills a process.");
                print("length (path): Gets the length of a file.");
                print("usr: Shows all users.");
            }

            //Get Directories:
            if (args[0] == "getdirs")
            {
                try
                {
                    string[] dirs = fs.getDirectories(args[1]);
                    int i;

                    for (i = 0; i < dirs.Length; i++)
                    {
                        print(dirs[i]);
                    }
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Get Files:
            if (args[0] == "getfiles")
            {
                try
                {
                    string[] files = fs.getFiles(args[1]);
                    int i;

                    for (i = 0; i < files.Length; i++)
                    {
                        print(files[i]);
                    }
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Check File:
            if (args[0] == "checkfile")
            {
                try
                {
                    if (fs.fileExists(args[1]))
                    {
                        print("File exists: " + args[1]);
                        return;
                    }

                    print("File does not exist: " + args[1]);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Check Dir:
            if (args[0] == "checkdir")
            {
                try
                {
                    if (fs.dirExists(args[1]))
                    {
                        print("Directory exists: " + args[1]);
                        return;
                    }

                    print("Directory does not exist: " + args[1]);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Create File:
            if (args[0] == "createfile")
            {
                try
                {
                    fs.createFile(args[1]);
                    print("File created: " + args[1]);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Read:
            if (args[0] == "read")
            {
                try
                {
                    string contents = fs.read(args[1]);
                    print(contents);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Launch:
            if (args[0] == "launch")
            {
                try
                {
                    launcher.launch(args[1]);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Getsrc:
            if (args[0] == "getsrc")
            {
                try
                {
                    string src = client.getHTMLSource(args[1]);
                    print(src);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Resolve:
            if (args[0] == "resolve")
            {
                try
                {
                    string IP = client.getIP(args[1]);
                    print(IP);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Print:
            if (args[0] == "print")
            {
                try
                {
                    print(args[1]);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Clear:
            if (args[0] == "clear")
            {
                Console.Clear();
            }

            //Date:
            if (args[0] == "date")
            {
                string date = DateTime.Now.ToString();
                print(date);
            }

            //Rand:
            if (args[0] == "rand")
            {
                int num = numgen.getNum();
                print(num.ToString());
            }

            //Killproc:
            if (args[0] == "killproc")
            {
                try
                {
                    os.killProcess(args[1]);
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //Length:
            if (args[0] == "length")
            {
                try
                {
                    string contents = fs.read(args[1]);
                    int length = contents.Length;
                    print(length.ToString());
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }

            //USR:
            if (args[0] == "usr")
            {
                try
                {
                    string[] users = os.getUsers();
                    int i;

                    for (i = 0; i < users.Length; i++)
                    {
                        print(users[i]);
                    }
                }
                catch (Exception e)
                {
                    print(e.ToString());
                }
            }
        }

        //Print:
        private static void print(string text)
        {
            Console.WriteLine(text);
        }
    }
}