using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class CodeClass
    {
        public static List<string> ScanFile(String FilePath, String SeachStr, SearchOption Directories)
        {

            List<string> List = new List<string>();
            DirectoryInfo oDirectoryInfo = new DirectoryInfo(FilePath);
            FileInfo[] oFileInfo = oDirectoryInfo.GetFiles(SeachStr, Directories);
            foreach (FileInfo filename in oFileInfo)
            {
                List.Add(filename.FullName);
            }



            return List;

        }


        public static void CreatTxtFile(string FilePath, string Name)
        {
            string DelPath = setting.DelTxtPath;

            if (Directory.Exists(DelPath) == false)
            {
                CodeAll.AddLog("文本数据库路径不存在","","");
                DelPath = setting.TempDelTxtPath;
                if (Directory.Exists(DelPath) == false)
                {
                    Directory.CreateDirectory(DelPath);
                }
            }

            if (File.Exists(FilePath) == false)
            {
                CodeAll.AddLog("NoFilePath", FilePath, "");
                return;
            }

            //获取文件大小


            long lSize = new FileInfo(FilePath).Length;
            string size = "";

            if (lSize >= 1073741824)
            {
                size = (lSize / 1024.00 / 1024.00 / 1024.00).ToString("F2") + "G";
            }
            else if (lSize >= 1048576)
            {
                size = (lSize / 1024.00 / 1024.00).ToString("F2") + "MB";
            }
            else if (lSize >= 1024)
            {
                size = (lSize / 1024.00).ToString("F2") + "KB";
            }
            else
            {
                size = lSize.ToString("F2") + "B";
            }

            //////////////////////////////////////////////

            string TxtPath = DelPath + "\\" + Name + " " + size + ".txt";

            if (File.Exists(TxtPath) == false)
            {
                FileStream myFs = new FileStream(TxtPath, FileMode.Create);
                myFs.Close();
            }
            else
            {
                CodeAll.AddLog("Txt数据已存在", TxtPath, "");
            }


        }



        public static string SameStr = "(重复项)";
        public static string SameStrAdd(string Str)
        {
            return Str + SameStr;
        }

        public static string SameStrClear(string Str)
        {
            return Str.Substring(0, Str.Length - SameStr.Length);
        }

        public static bool SameStrExist(string Str)
        {
            return (Str.Substring(Str.Length - SameStr.Length) == SameStr);
        }

    }
}
