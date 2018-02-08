using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class setting
    {
        public static string DataPath = Environment.CurrentDirectory + @"\data.mdb";
        public static System.Windows.Forms.RichTextBox LogBox;

        public static string TempDelTxtPath = Environment.CurrentDirectory + @"\Del";
        public static string DelTxtPath = @"\\192.168.2.80\Raid\XX\Del";
    }
}
