using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class setting
    {
        public static System.Windows.Forms.RichTextBox LogBox;

        public static string IP = @"\\192.168.2.80\";


        //Web Sexinsex 数据库
        public static string SSDataPath = Environment.CurrentDirectory + @"\sexinsex.mdb";

        //movie 数据库
        public static string DataPath = Environment.CurrentDirectory + @"\data.mdb";
        //movie 删除TXT临时目录
        public static string TempDelTxtPath = Environment.CurrentDirectory + @"\Del\";
        //movie 删除TXT目录
        public static string DelTxtPath = IP + @"Raid\XX\Del\";


        //everything 目录
        public static string EverythingPath = IP + @"Raid\Soft\everything\everything.exe";

        //ConvertVideo
        public static string ConcatVideoPath = IP + @"Raid\XX\ConcatVideo\";
        //ConvertVideo 远程替换目录
        public static string localPath = "/home/Raid/";
    }
}
