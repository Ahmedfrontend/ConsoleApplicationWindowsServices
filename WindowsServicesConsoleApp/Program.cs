using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WindowsServicesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<ServicesClass>(s =>
                {
                    s.ConstructUsing(servicesClass => new ServicesClass());
                    s.WhenStarted(servicesClass => servicesClass.Start());
                    s.WhenStopped(servicesClass => servicesClass.Stop());

                });
                x.SetServiceName("WindowsSerivceConsole");
                x.SetDisplayName("Windows Serivce Console");
                x.SetDescription("this is sample windows services App!!!");


            });
            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
