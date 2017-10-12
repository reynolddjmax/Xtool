using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public class CodeAll
    {


        //判断是否为视频格式

        public static bool isVideo(string Path)
        {
            if (!System.IO.File.Exists(Path)) return false;

            string str = "|" + Path.Substring(Path.LastIndexOf(".") + 1) + "|";


            string Type = "|mp4|mkv|flv|wmv|rm|rmvb|mov|3gp|avi|mpg|qt|f4v|m4v|imv|";


            return Type.IndexOf(str.ToLower()) != -1;
        }


        //搜索视频
        public static List<string> ScanVideo(String FilePath, String SeachStr, SearchOption Directories)
        {

            List<string> List = new List<string>();
            DirectoryInfo oDirectoryInfo = new DirectoryInfo(FilePath);
            FileInfo[] oFileInfo = oDirectoryInfo.GetFiles(SeachStr, Directories);
            foreach (FileInfo filename in oFileInfo)
            {
                if (isVideo(filename.FullName))
                {
                    List.Add(filename.FullName);
                }
                
            }



            return List;

        }


        //获取文件MD5校验码
        public static string GetMD5(string strFile)
        {
            try
            {
                int iFileSize = 30 * 1024 * 1024;

                //以文件的全路径对应的字符串和文件打开模式来初始化FileStream文件流实例
                FileStream SplitFileStream = new FileStream(strFile, FileMode.Open);
                //以FileStream文件流来初始化BinaryReader文件阅读器
                BinaryReader SplitFileReader = new BinaryReader(SplitFileStream);
                //每次分割读取的最大数据
                byte[] TempBytes = SplitFileReader.ReadBytes(iFileSize);

                MD5 md5 = MD5.Create();

                byte[] data2 = md5.ComputeHash(TempBytes);



                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data2.Length; i++)
                {
                    sb.Append(data2[i].ToString("x2"));
                }

                SplitFileStream.Close();
                SplitFileReader.Close();
                return sb.ToString();
            }
            catch (Exception ex)
            {

                CodeAll.AddLog("MD5验证失败", strFile, ex.Message);

                return "";
            }



        }

        public static void AddLog(string Type,string FilePath , string ExMessage)
        {

            setting.LogBox.Text += Type + "|" + FilePath + "|" + ExMessage + "\r\n";

        }
    }
}
