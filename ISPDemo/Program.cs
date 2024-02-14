using ISPDemo.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ISPDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            HpPrinter Obj = new HpPrinter();
            string content = null;
            Obj.PrintContent(content);


            Console.ReadLine();


        }
    }
}