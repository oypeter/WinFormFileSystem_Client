﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormFileSystem.HttpRequest;
using Filesystem;

namespace WinFormFileSystem.Forms
{
    public partial class Form_FileSystem : Form
    {
        public Form_FileSystem()
        {
            InitializeComponent();
        }

        private void Form_FileSystem_Load(object sender, EventArgs e)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientGetDirInfo();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("dir-ls", "root");
            FlushList((DirInfo)httpClient.GetResponse());
        }

        private void FlushList(DirInfo dirInfo)
        {
            this.listView_Dir.BeginUpdate();
            foreach (FileInfo fileInfo in dirInfo.FileInfo)
            {
                ListViewItem item = listView_Dir.Items.Add(fileInfo.FileName);
                item.SubItems.Add(fileInfo.Type.ToString());
                item.SubItems.Add(fileInfo.Length.ToString());
                item.SubItems.Add(fileInfo.FatherDir);
                item.SubItems.Add(fileInfo.Owner);
                item.SubItems.Add(fileInfo.Group);
                item.SubItems.Add(Convert.ToString(fileInfo.Power,2));

            }
            this.listView_Dir.EndUpdate();
        }
    }
}
