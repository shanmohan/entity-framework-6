using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalina.Repository;
using Catalina.Entities;

namespace Catalina.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalina.Console.Program.InsertSSR();
            Catalina.Console.Program.GetSSRList();
        }

        public static void InsertSSR()
        {
            CatalinaContext dbContext = new CatalinaContext();
            dbContext.Database.Log = System.Console.WriteLine;
            dbContext.SSRs.Add(new SSR() { Remarks = "this is my first remakr", SSRCode = "ABCD" });
            dbContext.SaveChanges();
        }

        public static void GetSSRList()
        {
            CatalinaContext dbContext = new CatalinaContext();
            List<SSR> ssrList =  dbContext.SSRs.ToList();
        }
    }
}
