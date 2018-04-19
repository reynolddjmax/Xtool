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
        

        //movie 数据库
        public static string DataPath = Environment.CurrentDirectory + @"\data.mdb";
        //movie 删除TXT临时目录
        public static string TempDelTxtPath = Environment.CurrentDirectory + @"\Del\";
        //movie 删除TXT目录
        public static string DelTxtPath = IP + @"Raid\XX\Del\";

        //ConvertVideo
        public static string ConcatVideoPath = IP + @"Raid\XX\ConcatVideo\";
        //ConvertVideo 远程替换目录
        public static string localPath = "/home/Raid/";
    }
}
