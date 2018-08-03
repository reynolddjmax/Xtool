using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    public class access
    {

        public static OleDbConnection conn;


        public static void Open()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + setting.DataPath;
            conn.Open();
        }

        public static void Open(string Path)
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path;
            conn.Open();
        }

        public static void Close()
        {
            conn.Close();
        }

        public class AccessType
        {
            public string Name;
            public string Size;
            public string MD5;
            public string UpdateTime;
            public string CreatTime;
            public string isDel;
        }

        public static bool UpdateAccess(string sql)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;

            command.CommandText = sql;

            try
            {
                command.ExecuteNonQuery();

                return true;
            }

            catch (Exception ex)
            {
                CodeAll.AddLog("数据库操作失败", sql, ex.Message);

                return false;

            }
        }

        public static DataTable GetAccess(string sql)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;

            OleDbDataReader dr = null;
            command.CommandText = sql;
            DataTable dt = new DataTable();


            try
            {

                dr = command.ExecuteReader();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    DataColumn dc = new DataColumn(dr.GetName(i), dr.GetFieldType(i));
                    dt.Columns.Add(dc);
                }

                while (dr.Read())
                {
                    DataRow ddr = dt.NewRow();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        ddr[i] = dr.GetValue(i).ToString();
                    }
                    dt.Rows.Add(ddr);
                }


                dr.Dispose();

                return dt;

            }
            catch (Exception ex)
            {
                CodeAll.AddLog("数据库操作失败", sql, ex.Message);
                return null;
            }
        }

        //添加数据库
        //1.路径，名称，类型，是否删除
        //2.校验MD5数值，查询数据库是否存在
        //3.存在没标记删除（标记删除并记录），存在已标记删除（报错），不存在（添加）

        public static bool AddData(string FilePath ,string Name ,string DataType ,string MD5, bool isDel)
        {

            if (DataType == "")
            {
                CodeAll.AddLog("数据库添加失败", "", "为选择类型");

                return false;
            }

            //获取文件信息

            FileInfo fi = new FileInfo(FilePath);

            long FileSize = fi.Length;
            DateTime CreatTime = fi.CreationTime;

            if (MD5 == "") MD5 = CodeAll.GetMD5(FilePath);


            if (MD5 == "")
            {
                return false;
            }

            //先查询是否存在 存在跳过 不存在添加数据

            if (ExistData(FilePath,DataType,MD5) == true)
            {
                CodeAll.AddLog("数据库添加失败", FilePath, "已存在");

                if (isDel)
                {
                    UpdateAccess("update " + DataType + " set [isDel] = " + isDel + " where [MD5] = '" + MD5 + "'");
                    CodeAll.AddLog("数据库标记删除", "", isDel.ToString());
                }
                else
                {
                    CodeAll.AddLog("跳过", "", "");
                }

                return false;
            }
            else
            {
                return UpdateAccess("insert into " + DataType + "([Name],[Size],[MD5],[UpdateTime],[CreatTime],[isDel]) values ('" + Name.Replace("'","") + "','" + FileSize + "','" + MD5 + "','" + DateTime.Now + "','" + CreatTime + "'," + isDel + ")");
            }

            
        }


        //检查是否存在
        public static bool ExistData(string FilePath, string DataType ,string MD5)
        {
            FileInfo fi = new FileInfo(FilePath);

            long FileSize = fi.Length;
            DateTime CreatTime = fi.CreationTime;

            if (MD5 == "")
            {
                MD5 = CodeAll.GetMD5(FilePath);
            }



            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            OleDbDataReader dr = null;
            command.CommandText = "select [MD5] from " + DataType + " where [MD5] = '" + MD5 + "'";

            try
            {

                dr = command.ExecuteReader();
                bool Exist = dr.HasRows;
                return Exist;

            }
            catch (Exception ex)
            {

                CodeAll.AddLog("查询数据库失败", FilePath, ex.Message);

                return true;
            }

        }



        //查询数据库所有类型（是否存在文件）
        //1.路径，名称，类型
        //2.反回查询结果
        public static AccessType CheckData(string FilePath, string DataType, string MD5)
        {
            if (MD5 == "")
            {
                MD5 = CodeAll.GetMD5(FilePath);
            }

            DataTable dt = GetAccess("select * from " + DataType + " where MD5='" + MD5 + "'");

            if (dt == null) return null;

            AccessType AT = new AccessType();

            if (dt.Rows.Count != 0)
            {
                AT.Name = dt.Rows[0][1].ToString();
                AT.Size = dt.Rows[0][2].ToString();
                AT.MD5 = dt.Rows[0][3].ToString();
                AT.UpdateTime = dt.Rows[0][4].ToString();
                AT.CreatTime = dt.Rows[0][5].ToString();
                AT.isDel = dt.Rows[0][6].ToString();
            }
            else
            {
                return null;
            }

            return AT;
        }

    }
}
