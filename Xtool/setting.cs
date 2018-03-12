using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class setting
    {
        public static string IP = @"\\192.168.2.80\";
        public static string localPath = "/home/Raid/";

        //movie database
        public static string DataPath = Environment.CurrentDirectory + @"\data.mdb";
        public static System.Windows.Forms.RichTextBox LogBox;
        
        public static string TempDelTxtPath = Environment.CurrentDirectory + @"\Del\";
        public static string DelTxtPath = IP + @"Raid\XX\Del\";

        //ConvertVideo
        public static string ConcatVideoPath = IP + @"Raid\XX\ConcatVideo\";

    }
}
