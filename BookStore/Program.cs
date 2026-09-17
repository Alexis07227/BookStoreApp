using OfficeOpenXml;
using System;
using System.ComponentModel;
using System.Windows.Forms;



namespace BookStore
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            
            
            Application.Run(new Form1());


        }
    }
}