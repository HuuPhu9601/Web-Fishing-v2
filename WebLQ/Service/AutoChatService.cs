using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebLQ.Models;

namespace WebLQ.Service
{
    public class AutoChatService
    {
       
        public void ReadFile(List<BinhLuan> binhLuans)
        {
            using (StreamReader SR = new StreamReader("binhluan" + ".txt"))
            {
                string key = "";
                while ((key = SR.ReadLine()) != null)
                {
                    BinhLuan bl = new BinhLuan();
                    bl.Name = key;
                     bl.Value = SR.ReadLine();
                    binhLuans.Add(bl);
                }

            }
        }
        public void sleep(double s)
        {
            Thread.Sleep(TimeSpan.FromSeconds(s));
        }
    }
}
