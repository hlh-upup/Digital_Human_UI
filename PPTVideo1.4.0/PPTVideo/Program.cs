﻿using System;
using System.Windows.Forms;

namespace PPTVideo
{
     static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 

        public static FormMain fm;
        public static FormNumberPerson fnp;
        public static FormTrain ft;
        public static FlaskConnect Flask;
        public static FileOperation File;


        [STAThread]
        static void Main()
        {
            Flask = new FlaskConnect("http://127.0.0.1:6006"); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ft = new FormTrain();
            fnp = new FormNumberPerson();
            fm = new FormMain();
            File = new FileOperation();
            Application.Run(fm);
        }
    }
}
