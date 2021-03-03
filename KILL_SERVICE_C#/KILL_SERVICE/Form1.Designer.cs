namespace KILL_SERVICE
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.START_STOP_BTN = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LISTS_DATA = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LISTS_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "服務停止機";
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.Location = new System.Drawing.Point(250, 44);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(75, 23);
            this.ADD_BTN.TabIndex = 1;
            this.ADD_BTN.Text = "新增服務";
            this.ADD_BTN.UseVisualStyleBackColor = true;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // START_STOP_BTN
            // 
            this.START_STOP_BTN.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.START_STOP_BTN.Location = new System.Drawing.Point(115, 367);
            this.START_STOP_BTN.Name = "START_STOP_BTN";
            this.START_STOP_BTN.Size = new System.Drawing.Size(113, 35);
            this.START_STOP_BTN.TabIndex = 3;
            this.START_STOP_BTN.Text = "啟動";
            this.START_STOP_BTN.UseVisualStyleBackColor = true;
            this.START_STOP_BTN.Click += new System.EventHandler(this.START_STOP_BTN_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // LISTS_DATA
            // 
            this.LISTS_DATA.AllowUserToAddRows = false;
            this.LISTS_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LISTS_DATA.Location = new System.Drawing.Point(10, 73);
            this.LISTS_DATA.Name = "LISTS_DATA";
            this.LISTS_DATA.ReadOnly = true;
            this.LISTS_DATA.RowTemplate.Height = 24;
            this.LISTS_DATA.Size = new System.Drawing.Size(314, 287);
            this.LISTS_DATA.TabIndex = 2;
            this.LISTS_DATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LISTS_DATA_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "說明";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.START_STOP_BTN);
            this.Controls.Add(this.LISTS_DATA);
            this.Controls.Add(this.ADD_BTN);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(349, 453);
            this.MinimumSize = new System.Drawing.Size(349, 453);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KillService";
            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.LISTS_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.Button START_STOP_BTN;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView LISTS_DATA;
        private System.Windows.Forms.Button button1;
    }
}

