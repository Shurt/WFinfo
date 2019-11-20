﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WFInfoCS
{
    class Main{
        private string appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WFInfoCS";
        private Brush lightBlue = new SolidColorBrush(Color.FromRgb(177, 208, 217));
        private string buildVersion = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private uint hotKey = 0x24;
        public Main(){

        }

        public void AddLog(string argm)
        { //write to the debug file, includes version and UTCtime
            string path = appPath + @"\Debug";
            Console.WriteLine(argm);
            Directory.CreateDirectory(path);
            using (StreamWriter sw = File.AppendText(path + @"\debug.txt"))
            {
                sw.WriteLineAsync("[" + DateTime.UtcNow + " " + BuildVersion + "] \t" + argm);
            }
        }


        //getters, boring shit
        public string BuildVersion { get => buildVersion; }
        public Brush LightBlue { get => lightBlue; }
        public string AppPath { get => AppPath; }
        public uint HotKey { get => hotKey; }
    }
}