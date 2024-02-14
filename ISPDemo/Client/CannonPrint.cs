﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPDemo.Client
{
    public class CannonPrint : IPrintScanContent
    {

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}