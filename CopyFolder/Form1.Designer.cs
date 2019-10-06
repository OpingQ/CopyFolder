namespace CopyFolder
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FBD_DiaBox = new System.Windows.Forms.FolderBrowserDialog();
            this.lab_copy = new System.Windows.Forms.Label();
            this.lab_toFolder = new System.Windows.Forms.Label();
            this.TB_copyTo = new System.Windows.Forms.TextBox();
            this.Btn_Browser = new System.Windows.Forms.Button();
            this.Btn_BeginCopy = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.LB_SelectedFolder = new System.Windows.Forms.ListBox();
            this.PB_Bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lab_copy
            // 
            this.lab_copy.AutoSize = true;
            this.lab_copy.Location = new System.Drawing.Point(10, 13);
            this.lab_copy.Name = "lab_copy";
            this.lab_copy.Size = new System.Drawing.Size(98, 12);
            this.lab_copy.TabIndex = 1;
            this.lab_copy.Text = "要複製的資料夾 : ";
            // 
            // lab_toFolder
            // 
            this.lab_toFolder.AutoSize = true;
            this.lab_toFolder.Location = new System.Drawing.Point(12, 205);
            this.lab_toFolder.Name = "lab_toFolder";
            this.lab_toFolder.Size = new System.Drawing.Size(50, 12);
            this.lab_toFolder.TabIndex = 2;
            this.lab_toFolder.Text = "複製到 : ";
            // 
            // TB_copyTo
            // 
            this.TB_copyTo.Location = new System.Drawing.Point(12, 231);
            this.TB_copyTo.Name = "TB_copyTo";
            this.TB_copyTo.ReadOnly = true;
            this.TB_copyTo.Size = new System.Drawing.Size(440, 22);
            this.TB_copyTo.TabIndex = 3;
            // 
            // Btn_Browser
            // 
            this.Btn_Browser.Location = new System.Drawing.Point(458, 231);
            this.Btn_Browser.Name = "Btn_Browser";
            this.Btn_Browser.Size = new System.Drawing.Size(67, 23);
            this.Btn_Browser.TabIndex = 4;
            this.Btn_Browser.Text = "瀏覽";
            this.Btn_Browser.UseVisualStyleBackColor = true;
            this.Btn_Browser.Click += new System.EventHandler(this.Btn_Browser_Click);
            // 
            // Btn_BeginCopy
            // 
            this.Btn_BeginCopy.Location = new System.Drawing.Point(458, 260);
            this.Btn_BeginCopy.Name = "Btn_BeginCopy";
            this.Btn_BeginCopy.Size = new System.Drawing.Size(66, 23);
            this.Btn_BeginCopy.TabIndex = 5;
            this.Btn_BeginCopy.Text = "開始複製";
            this.Btn_BeginCopy.UseVisualStyleBackColor = true;
            this.Btn_BeginCopy.Click += new System.EventHandler(this.Btn_BeginCopy_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(361, 8);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "新增";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(443, 8);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "刪除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // LB_SelectedFolder
            // 
            this.LB_SelectedFolder.FormattingEnabled = true;
            this.LB_SelectedFolder.ItemHeight = 12;
            this.LB_SelectedFolder.Location = new System.Drawing.Point(12, 36);
            this.LB_SelectedFolder.Name = "LB_SelectedFolder";
            this.LB_SelectedFolder.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_SelectedFolder.Size = new System.Drawing.Size(505, 160);
            this.LB_SelectedFolder.TabIndex = 8;
            // 
            // PB_Bar
            // 
            this.PB_Bar.Location = new System.Drawing.Point(14, 260);
            this.PB_Bar.Name = "PB_Bar";
            this.PB_Bar.Size = new System.Drawing.Size(226, 23);
            this.PB_Bar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 290);
            this.Controls.Add(this.PB_Bar);
            this.Controls.Add(this.LB_SelectedFolder);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_BeginCopy);
            this.Controls.Add(this.Btn_Browser);
            this.Controls.Add(this.TB_copyTo);
            this.Controls.Add(this.lab_toFolder);
            this.Controls.Add(this.lab_copy);
            this.Name = "Form1";
            this.Text = "選擇要複製的資料夾";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FBD_DiaBox;
        private System.Windows.Forms.Label lab_copy;
        private System.Windows.Forms.Label lab_toFolder;
        private System.Windows.Forms.TextBox TB_copyTo;
        private System.Windows.Forms.Button Btn_Browser;
        private System.Windows.Forms.Button Btn_BeginCopy;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ListBox LB_SelectedFolder;
        private System.Windows.Forms.ProgressBar PB_Bar;
    }
}

