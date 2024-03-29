﻿using log4net;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.MyForm.AdminForm;
using Shared_Novel_Reader.Tools;
using Shared_Novel_Reader.Tools.API.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{ 
    [System.Runtime.InteropServices.ComVisible(true)]  //放在命名空间和类的中间(与class 同等级)
    public partial class FormRootControl : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormRootControl));
        public bool IsFindAll = true;
        public string UserIDStr = String.Empty;
        public string UserNameStr = String.Empty;
        public string UserSexStr = String.Empty;

        public string BeginTime = string.Empty;
        public string EndTime = string.Empty;
        public FormRootControl()
        {
            //调用
            SetWebBrowserFeatures(10);
            InitializeComponent();
            LevelInit();
            WebEchartInit();
            LoadAllUser();
        }


        /// <summary>
        /// 查询所有
        /// </summary>
        public async void LoadAllUser()
        {
            if (!IsFindAll) return;
            // 发送请求
            var UserListResult = Task<MyResponse>.Run(() => User.AllUserList());

            MyResponse res = await UserListResult;


            // 加载前把残留的数据删除
            DataGridViewUser.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("用户列表查询失败");
            }
            else if (res.Data["UserList"].ToString() == "")
            {
                log.Info("用户列表为空");
            }
            else
            {

                string[][] UserListStr;
                JArray UserListJson = (JArray)res.Data["UserList"];
                // log.Info(UserListJson.ToString());
                GetUserList(in UserListJson, out UserListStr);
                for (int i = 0; i < UserListJson.Count; i++)
                {
                    DataGridViewUser.Rows.Add(UserListStr[i]);
                }
                log.Info("用户列表查询成功");
            }
        }


        /// <summary>
        /// 查询部分
        /// </summary>
        public async void LoadSomeUser()
        {
            if (IsFindAll) return;

            // 数据处理
            int UserID = -1;
            if (UserIDStr != "")
            {
                UserID = Convert.ToInt32(UserIDStr);
            }

            if (UserSexStr == "无")
            {
                UserSexStr = "";
            }
            log.Info("正在查询指定用户(ID:" + UserID + ",Name:" + UserNameStr + ",Sex:" + UserSexStr + ")");

            JObject ReqJson = new JObject();
            ReqJson["User_ID"] = UserID;
            ReqJson["User_Name"] = UserNameStr;
            ReqJson["User_Sex"] = UserSexStr;
            // 发送请求
            var UserListResult = Task<MyResponse>.Run(() => User.SomeUserList(ReqJson));

            MyResponse res = await UserListResult;

            // 加载前把残留的数据删除
            DataGridViewUser.Rows.Clear();


            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("指定用户查询失败");
            }
            else if (res.Data["UserList"].ToString() == "")
            {
                log.Info("用户列表为空");
            }
            else
            {
                string[][] UserListStr;
                JArray UserListJson = (JArray)res.Data["UserList"];
                // log.Info(UserListJson.ToString());
                GetUserList(in UserListJson, out UserListStr);
                for (int i = 0; i < UserListJson.Count; i++)
                {
                    DataGridViewUser.Rows.Add(UserListStr[i]);
                }
                log.Info("指定用户查询成功");
            }

        }

        private void GetUserList(in JArray UserListJson, out string[][] UserListStr)
        {
            UserListStr = new string[UserListJson.Count][];

            string[] ColName = new string[DataGridViewUser.ColumnCount];
            for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
            {
                ColName[i] = DataGridViewUser.Columns[i].Name;
            }

            for (int i = 0; i < UserListJson.Count; i++)
            {
                string[] RowData = new string[DataGridViewUser.ColumnCount];
                for (int j = 0; j < DataGridViewUser.ColumnCount; j++)
                {
                    if (ColName[j] == "User_Name")
                    {
                        RowData[j] = UserListJson[i]["Name"].ToString();
                        continue;
                    }
                    RowData[j] = UserListJson[i][ColName[j]].ToString();
                }

                UserListStr[i] = RowData;
            }
            return;

        }

        private void ReFind_Click(object sender, EventArgs e)
        {
            // 展示前选择搜索范围
            // 弹出确认框
            FormFilterUserManagement FilterUserList = new FormFilterUserManagement();
            // 初始化 如果上次有搜索则在这里恢复
            FilterUserList.TextUserID.Text = this.UserIDStr;
            FilterUserList.TextName.Text = this.UserNameStr;
            if (this.UserSexStr == "")
            {
                FilterUserList.ComboBoxSex.SelectedItem = "无";
            }
            else
            {
                FilterUserList.ComboBoxSex.SelectedItem = this.UserSexStr;
            }
            DialogResult res = FilterUserList.ShowDialog();

            // 根据结果决定搜索范围   OK-FindAll   Yes-FindSome   Cancel-NoFInd
            if (res == DialogResult.OK)
            {
                this.IsFindAll = true;
                this.LoadAllUser();
                this.Show();
            }
            else if (res == DialogResult.Yes)
            {
                this.IsFindAll = false;
                this.UserIDStr = FilterUserList.TextUserID.Text;
                this.UserNameStr = FilterUserList.TextName.Text;
                this.UserSexStr = FilterUserList.ComboBoxSex.SelectedItem.ToString();

                this.LoadSomeUser();
                this.Show();
            }

            FilterUserList.Dispose();
        }

        private async void ViewDetails_Click(object sender, EventArgs e)
        {
            if (DataGridViewUser.Rows.Count == 0) return;

            int RowIndex = -1;
            foreach(DataGridViewRow row in DataGridViewUser.Rows)
            {
                if(row.Selected)
                {
                    RowIndex = row.Index;
                    break;
                }
            }
            if(RowIndex == -1) return;
            string show = "";
            string[] ColName = new string[DataGridViewUser.ColumnCount];
            string[] ColHead = new string[DataGridViewUser.ColumnCount];
            for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewUser.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewUser.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
            {
                show += ColHead[i] + " : " + (string)DataGridViewUser.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }
            if ((string)DataGridViewUser.Rows[RowIndex].Cells[7].Value == "Ban")
            {
                string Time = "";

                // 发送请求
                var SearchRes = Task<MyResponse>.Run(() => Tools.API.GPI.SearchBanTime(Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells[0].Value)));

                MyResponse res = await SearchRes;

                if (res == null)
                {
                    Time = "网络异常,请重试";
                    return;
                }
                else if (!res.Result || res.Data.ToString() == "")
                {
                    Time = "查询封号截止时间失败";
                    return;
                }
                else
                {
                    Time = res.Data["Ban_Time"].ToString();
                }
                show += "封号截止时间:" + Time;
            }

            MessageBox.Show(show);
        }


        private async void AdminControl_Click(object sender, EventArgs e)
        {

            if (DataGridViewUser.Rows.Count == 0) return;

            int RowIndex = -1;
            foreach (DataGridViewRow row in DataGridViewUser.Rows)
            {
                if (row.Selected)
                {
                    RowIndex = row.Index;
                    break;
                }
            }
            if (RowIndex == -1) return;

            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.User.AdminControl(Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells[0].Value)));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("管理员操作失败:"+res.Message);
            }
            else
            {
                MessageBox.Show(res.Message);
                for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
                {
                    string colName = DataGridViewUser.Columns[i].Name;
                    if (colName == "User_Name")
                    {
                        DataGridViewUser.Rows[RowIndex].Cells[colName].Value = res.Data["Name"].ToString();
                        continue;
                    }
                    DataGridViewUser.Rows[RowIndex].Cells[colName].Value = res.Data[colName].ToString();
                }
            }

        }

        private void TabPageAdmin_Click(object sender, EventArgs e)
        {
            ReFind.PerformClick();
        }

        public async void LevelInit()
        {

            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.SearchSysOutLevel());

            MyResponse res = await SearchRes;

            if (res == null)
            {
                log.Info("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                log.Info("查询系统日志等级失败:" + res.Message);
            }
            else
            {
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"] , (bool)res.Data["WARN"]);
            }
        }

        public void RefreshLevel(bool TRACE, bool DEBUG, bool INFO, bool WARN)
        {
            if(TRACE)
            {
                this.LabelTRACEValue.Text = "已开启";
                this.BtnTRACEOpen.Visible = false;
                this.BtnTRACEClose.Visible = true;
            }
            else
            {
                this.LabelTRACEValue.Text = "未开启";
                this.BtnTRACEOpen.Visible = true;
                this.BtnTRACEClose.Visible = false;
            }
            if (DEBUG)
            {
                this.LabelDEBUGValue.Text = "已开启";
                this.BtnDEBUGOpen.Visible = false;
                this.BtnDEBUGClose.Visible = true;
            }
            else
            {
                this.LabelDEBUGValue.Text = "未开启";
                this.BtnDEBUGOpen.Visible = true;
                this.BtnDEBUGClose.Visible = false;
            }
            if (INFO)
            {
                this.LabelINFOValue.Text = "已开启";
                this.BtnINFOOpen.Visible = false;
                this.BtnINFOClose.Visible = true;
            }
            else
            {
                this.LabelINFOValue.Text = "未开启";
                this.BtnINFOOpen.Visible = true;
                this.BtnINFOClose.Visible = false;
            }
            if (WARN)
            {
                this.LabelWARNValue.Text = "已开启";
                this.BtnWARNOpen.Visible = false;
                this.BtnWARNClose.Visible = true;
            }
            else
            {
                this.LabelWARNValue.Text = "未开启";
                this.BtnWARNOpen.Visible = true;
                this.BtnWARNClose.Visible = false;
            }
        }

        private async void BtnTRACEOpen_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "TRACE";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(TRACE)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(TRACE)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }
        }

        private async void BtnTRACEClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "TRACE";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(TRACE)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(TRACE)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnDEBUGOpen_Click(object sender, EventArgs e)
        {

            JObject ReqJson = new JObject();
            ReqJson["Level"] = "DEBUG";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(DEBUG)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(DEBUG)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }
        }

        private async void BtnDEBUGClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "DEBUG";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(DEBUG)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(DEBUG)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnINFOOpen_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "INFO";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(INFO)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(INFO)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }
        private async void BtnINFOClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "INFO";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(INFO)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(INFO)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnWARNOpen_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "WARN";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(WARN)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(WARN)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnWARNClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "WARN";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(WARN)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(WARN)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要重启系统吗,在线用户的部分数据可能会丢失", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            JObject ReqJson = new JObject();
            ReqJson["Instruction"] = "restart";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.Instructions(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("系统操作失败(" + res.Message + ")");
            }
            else
            {
                MessageBox.Show("系统操作成功(" + res.Message + ")");
            }

        }

        private async void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭系统吗,关闭后需要到手动才能开启", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return ;
            }
            JObject ReqJson = new JObject();
            ReqJson["Instruction"] = "close";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.Instructions(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("系统操作失败(" + res.Message + ")");
            }
            else
            {
                MessageBox.Show("系统操作成功(" + res.Message + ")");
            }
        }


        public void WebEchartInit()
        {

            this.WebBrowserEcharts.ObjectForScripting = this;//传递参数到js
            string path = Properties.Settings.Default.App_Path + "\\echarts\\echarts.html";  //html路径
            this.WebBrowserEcharts.Url = new Uri(path);  //传入路径到webBrowser
/*
            // 修改大小
            string size_str = "[" + WebBrowserEcharts.Height.ToString() + "," + WebBrowserEcharts.Width.ToString() + "]";
            HtmlDocument htmlDocument = WebBrowserEcharts.Document;
            Console.WriteLine(size_str);
            htmlDocument.InvokeScript("setPosition", new object[] { size_str });
*/

            /* string size_str = "[" + WebBrowserEcharts.Size.Height.ToString() + "," + WebBrowserEcharts.Size.Width.ToString() + "]";
             Console.Out.WriteLine(WebBrowserEcharts.Size.Height.ToString());
             Console.Out.WriteLine(size_str);
             HtmlDocument htmlDocument = WebBrowserEcharts.Document;
             object[] objArray = new object[] { size_str };
             Console.Out.WriteLine("object:" + objArray[0].ToString());
             object ret = htmlDocument.InvokeScript("setPosition", objArray);
             Console.Out.WriteLine("Return:" + ret);*//*
             WebBrowserEcharts.Navigate("javascript:[alert(1)];");*/
        }



        static void SetWebBrowserFeatures(int ieVersion)
        {
            // don't change the registry if running in-proc inside Visual Studio  
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
                return;
            //获取程序及名称  
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            //得到浏览器的模式的值  
            UInt32 ieMode = GeoEmulationModee(ieVersion);
            var featureControlRegKey = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\";
            //设置浏览器对应用程序（appName）以什么模式（ieMode）运行  
            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION",
                appName, ieMode, RegistryValueKind.DWord);
            // enable the features which are "On" for the full Internet Explorer browser  
            //不晓得设置有什么用  
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION",
                appName, 1, RegistryValueKind.DWord);
        }

        /// <summary>  
        /// 通过版本得到浏览器模式的值  
        /// </summary>  
        /// <param name="browserVersion"></param>  
        /// <returns></returns>  
        static UInt32 GeoEmulationModee(int browserVersion)
        {
            UInt32 mode = 11000; // Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode.   
            switch (browserVersion)
            {
                case 7:
                    mode = 7000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode.   
                    break;
                case 8:
                    mode = 8000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode.   
                    break;
                case 9:
                    mode = 9000; // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.                      
                    break;
                case 10:
                    mode = 10000; // Internet Explorer 10.  
                    break;
                case 11:
                    mode = 11000; // Internet Explorer 11  
                    break;
            }
            return mode;
        }

        /* #region 供外部js调用的方法
        /// <summary>
        /// 供外部js调用的方法
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
       public string functionForHtml(string mes)
        {
            // 将Html传递过来的数据设置到组件文本框中
            textBox1.Text = "收到Html的数据：" + mes;
            // 返回给Html的数据
            return "我已收到";
        }
        #endregion
        */


        private async Task<Echarts> GetEcharts(string BeginTime,string EndTime,string ReportType,string LineType)
        {
            string UnitType = String.Empty;
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.SearchReport(BeginTime, EndTime, ReportType));

            DateTime Begin = DateTime.Parse(BeginTime);
            DateTime End = DateTime.Parse(EndTime);
            string topTime = "起止时间: "+Begin.ToString("yyyy-MM-dd")+"~"+ End.ToString("yyyy-MM-dd");
            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return null;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("查看报表失败:" + res.Message);
                return null;
            }
            else
            {
                log.Info("查看报表成功:");
                //Console.WriteLine("Data:" + res.Data.ToString());
                String TableName = string.Empty;
                JArray ReportArray = res.Data["Report"] as JArray;
                Dictionary<string, Double[]> Dictionary = new Dictionary<string, Double[]>();
                if(ReportType == "Upload" || ReportType == "Download" || ReportType == "Economic")
                {
                    if (ReportType == "Economic")
                    {
                        UnitType = "元";
                        TableName = "系统收入";
                    }
                    else if(ReportType == "Upload" || ReportType == "Download")
                    {
                        UnitType = "次";
                        if(ReportType == "Upload")
                        {
                            TableName = "资源上传量";
                        }
                        else if (ReportType == "Download")
                        {
                            TableName = "资源下载量";
                        }
                    }
                    JArray value = new JArray();
                    Double sum = 0;
                    for (int i = 0; i < ReportArray.Count; i++)
                    {
                        // 第一级 年份
                        value.Add(ReportArray[i]["year"].ToString());

                        Double[] Month = new Double[13];
                        for (int j = 1; j < 13; j++)
                        {
                            Month[j] = Convert.ToDouble(ReportArray[i][Convert.ToString(j)].ToString());
                            sum += Month[j];
                        }
                        Dictionary[ReportArray[i]["year"].ToString()] = Month;
                    }
                    string topNum = "总和: " + Convert.ToString(sum) + UnitType;
                    Echarts ech = new Echarts(value, LineType, UnitType, TableName, topNum, topTime);


                    for (int j = 1; j < 13; j++)
                    {
                        JObject obj = new JObject();
                        obj["Month"] = j + "月";

                        for (int i = 0; i < Dictionary.Count; i++)
                        {
                            string year = Dictionary.Keys.ElementAt(i);
                            obj[year] = Dictionary[year][j];
                        }
                        ech.Add(obj);
                    }

                    Console.WriteLine(ech.ToJson().ToString());
                    return ech;
                }
                
                return null;
            }
        }

        private async Task<Echarts> InitReport()
        {
            string BeginTime = DateTime.Now.ToString("yyyy-01-01 00:00:00");
            string EndTime = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            return await GetEcharts(BeginTime, EndTime,"Economic", "bar");
        }

        #region
        public void RefreshReport(string JsonStr)
        {
            HtmlDocument htmlDocument = WebBrowserEcharts.Document;
            object[] objArray = new object[] { JsonStr };
            //htmlDocument.InvokeScript("show", objArray);
            htmlDocument.InvokeScript("Refresh", objArray);
        }
        #endregion

        private async void WebBrowserEcharts_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Echarts ech = await InitReport();
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());
        }

        private async void View_Economic_Report_bar_Click(object sender, EventArgs e)
        {
            ToolForm.FormDateSelect FormDateSelect = new ToolForm.FormDateSelect(BeginTime, EndTime);
            DialogResult DiaRes = FormDateSelect.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            BeginTime = FormDateSelect.Begin;
            EndTime = FormDateSelect.End;
            Echarts ech = await GetEcharts(BeginTime, EndTime, "Economic", "bar");
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());

        }

        private async void View_Economic_Report_line_Click(object sender, EventArgs e)
        {
            ToolForm.FormDateSelect FormDateSelect = new ToolForm.FormDateSelect(BeginTime, EndTime);
            DialogResult DiaRes = FormDateSelect.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            BeginTime = FormDateSelect.Begin;
            EndTime = FormDateSelect.End;
            Echarts ech = await GetEcharts(BeginTime, EndTime, "Economic", "line");
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());
        }

        private async void View_Upload_Report_line_Click(object sender, EventArgs e)
        {

            ToolForm.FormDateSelect FormDateSelect = new ToolForm.FormDateSelect(BeginTime, EndTime);
            DialogResult DiaRes = FormDateSelect.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            BeginTime = FormDateSelect.Begin;
            EndTime = FormDateSelect.End;
            Echarts ech = await GetEcharts(BeginTime, EndTime, "Upload", "line");
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());
        }

        private async void View_Upload_Report_bar_Click(object sender, EventArgs e)
        {
            ToolForm.FormDateSelect FormDateSelect = new ToolForm.FormDateSelect(BeginTime,EndTime);
            DialogResult DiaRes = FormDateSelect.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            BeginTime = FormDateSelect.Begin;
            EndTime = FormDateSelect.End;
            Echarts ech = await GetEcharts(BeginTime, EndTime, "Upload", "bar");
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());
        }

        private async void View_Download_Report_line_Click(object sender, EventArgs e)
        {
            ToolForm.FormDateSelect FormDateSelect = new ToolForm.FormDateSelect(BeginTime, EndTime);
            DialogResult DiaRes = FormDateSelect.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            BeginTime = FormDateSelect.Begin;
            EndTime = FormDateSelect.End;
            Echarts ech = await GetEcharts(BeginTime, EndTime, "Download", "line");
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());
        }

        private async void View_Download_Report_bar_Click(object sender, EventArgs e)
        {

            ToolForm.FormDateSelect FormDateSelect = new ToolForm.FormDateSelect(BeginTime, EndTime);
            DialogResult DiaRes = FormDateSelect.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            BeginTime = FormDateSelect.Begin;
            EndTime = FormDateSelect.End;
            Echarts ech = await GetEcharts(BeginTime, EndTime, "Download", "bar");
            if (ech == null)
                return;
            RefreshReport(ech.ToJson().ToString());
        }

        private async void ViewAction_Click(object sender, EventArgs e)
        {

            UserForm.FormActionList FormActionList = new UserForm.FormActionList();
            int RowIndex = DataGridViewUser.CurrentRow.Index;
            bool res = await FormActionList.LoadList(Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["User_ID"].Value));
            if (res)
            {
                FormActionList.Show();
            }
            else
            {
                FormActionList.Dispose();
            }
        }
    }
}

class Echarts
{
    bool Init = false;
    public string dimensions_Key = string.Empty;
    public string unit = String.Empty;
    public string tableName = String.Empty; 
    public string topNum = String.Empty;
    public string topTime = String.Empty;
    JArray dimensions_Value = new JArray();
    JArray source = new JArray();
    string LineType = string.Empty; 
    public Echarts(JArray value,string linetype,string Unit,string TableName,string TopNum,string TopTime)
    {
        dimensions_Key = "Month";
        dimensions_Value = value;
        LineType = linetype;
        unit = Unit + "/月份";
        tableName = TableName;
        topNum = TopNum;
        topTime = TopTime;
        Init = true;
    }

    public bool Add(JObject newLine)
    {
        if(!Init)return false;
        Dictionary<string, JTokenType> ColMap = new Dictionary<string, JTokenType>();
        ColMap.Add(dimensions_Key, JTokenType.String);
        for(int i = 0; i < dimensions_Value.Count; i++)
        {
            ColMap.Add(dimensions_Value[i].ToString(), JTokenType.Float);
        }
        if (!MyJson.CheckColAndTypeFromMap(newLine,ColMap))
            return false;
        source.Add(newLine);
        return true;
    }
    public JObject ToJson()
    {
        JObject obj = new JObject();
        obj["dimensions_Key"] = dimensions_Key;
        obj["dimensions_Value"] = dimensions_Value;

        JArray series = new JArray();
        for(int i = 0; i < dimensions_Value.Count; i++)
        {
            JObject temp = new JObject();
            temp["type"] = LineType;
            series.Add(temp);
        }
        obj["series"] = series;
        obj["source"] = source;
        obj["unit"] = unit;
        if(LineType == "line")
        {
            obj["tableName"] = tableName+"折线图";
        }
        else if(LineType == "bar")
        {
            obj["tableName"] = tableName + "柱形图";
        }
        obj["topNum"] = topNum;
        obj["topTime"] = topTime;

        return obj;
    }

}