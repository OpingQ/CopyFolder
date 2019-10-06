using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace CopyFolder
{
    public partial class Form1 : Form
    {
        private SaveData sd = new SaveData();
        private string saveDataTxt;

        public Form1()
        {
            InitializeComponent();
            saveDataTxt = Directory.GetCurrentDirectory() + "/saveData.json";
            try
            {
                using (var fs = File.Open(saveDataTxt, FileMode.OpenOrCreate))
                {
                    StreamReader sr = new StreamReader(fs);
                    var result = sr.ReadToEnd();
                    SaveData temp = JsonConvert.DeserializeObject<SaveData>(result);
                    if (temp != null)
                    {
                        sd = temp;
                    }
                }
            }
            catch
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TB_copyTo.Text = sd.toData;
            LB_SelectedFolder.DataSource = sd.selectedFolderStr;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            var result = JsonConvert.SerializeObject(sd);
            using (var fs = File.Open(saveDataTxt, FileMode.Create))
            {
                var bs = Encoding.UTF8.GetBytes(result);
                fs.Write(bs, 0, bs.Length);
            }
        }

        private void Btn_Browser_Click(object sender, EventArgs e)
        {
            if (FBD_DiaBox.ShowDialog() == DialogResult.OK)
            {
                var path = FBD_DiaBox.SelectedPath;
                TB_copyTo.Text = path;
                sd.toData = path;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (FBD_DiaBox.ShowDialog() == DialogResult.OK)
            {
                var strPath = FBD_DiaBox.SelectedPath;
                if (sd.selectedFolderStr.Contains(strPath))
                {

                    MessageBox.Show("此資料夾已選擇");
                    return;
                }
                sd.selectedFolderStr.Add(strPath);

            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var temp = new object[LB_SelectedFolder.SelectedItems.Count];
            LB_SelectedFolder.SelectedItems.CopyTo(temp, 0);
            foreach (var item in temp)
            {
                sd.selectedFolderStr.Remove(item.ToString());
            }
        }

        private async void Btn_BeginCopy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否開始複製!!") == DialogResult.Cancel)
            {
                return;
            }

            Btn_BeginCopy.Enabled = false;
            var dn = DateTime.Now;
            PB_Bar.Minimum = 0;
            PB_Bar.Value = 0;

            #region s1
            var total = 0;
            var curcount = 0;
            List<Task> tList = new List<Task>();
            foreach (var sourcePath1 in sd.selectedFolderStr)
            {
                var filePaths = Directory.GetFiles(sourcePath1, "*", SearchOption.AllDirectories);
                total += filePaths.Length;
                var ta = new Task((value) =>
                {

                    Object[] ar = (Object[])value;
                    var curRoot = sd.toData;
                    var sourcePath = ar[0].ToString();
                    var allFiles = (string[])(ar[1]);
                    var myFolderName = sourcePath.Substring(sourcePath.LastIndexOf("\\"));
                    var allFolder = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
                    curRoot = curRoot + myFolderName;
                    var temp = "";
                    foreach (var folder in allFolder)
                    {
                        temp = curRoot + folder.Replace(sourcePath, "");
                        if (!Directory.Exists(temp))
                        {
                            Directory.CreateDirectory(temp);
                        }
                    }

                    // var allFiles = Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories);

                    foreach (var file in allFiles)
                    {
                        temp = curRoot + file.Replace(sourcePath, "");
                        File.Copy(file, temp, true);
                        lock (PB_Bar)
                        {
                            curcount++;
                            this.Invoke(new Action(() => { PB_Bar.Value = curcount; }));
                        }
                    }

                }, new Object[] { sourcePath1, filePaths });
                tList.Add(ta);

            }
            PB_Bar.Maximum = total;
            

            tList.ForEach(t => { t.Start(); });
            foreach (var trun in tList)
            {
                await trun;
            }
            #endregion
            var offset = DateTime.Now.Subtract(dn);
            MessageBox.Show($"執行玩並共花了\n{offset.Seconds}秒");
            Btn_BeginCopy.Enabled = true;
        }

    }

}

