using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServicesConsoleApp
{
  public  class ServicesClass
    {
        private readonly Timer _timer;

        public ServicesClass()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] liens = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"D:\AA\TestApps\WindowsservicesFiles\TimeSheet.txt", liens);

        }
        public void Start() {
            _timer.Start();
        }
        public void Stop() {
            _timer.Stop();
        }
    }
}
