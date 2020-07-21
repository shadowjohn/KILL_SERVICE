using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utility;
using MyButtonCell_NAME;
using System.Threading;
using runThd_namespace;
namespace KILL_SERVICE
{

    public partial class Form1 : Form
    {
      
        runThd run1 = new runThd();
        string VERSION = "1.1";
        public myinclude my = new myinclude();
        //string icon = "AAABAAEAExEAAAEAIAB4BQAAFgAAACgAAAATAAAAIgAAAAEAIAAAAAAADAUAABILAAASCwAAAAAAAAAAAABQMT3/WEJP/zsoLv98WE//nXBg/1w+Qv87KDX/Pio4/005Sf9JNUX/STVE/1RAUP9SPUz/VUBQ/1Q5Rv+QYVH/mWRS/1AuLf8sGCf/cEdI/35gb/9LNEH/bFZf/5R2dv9oT1n/PCUz/0YxQv9kTmD/c1lq/3Zaa/9zXGv/a1Vl/25YaP9XQVL/gldS/1UvK/8oFSL/Rio9/4JNP/8+HSL/SzRA/3RbaP9+ZW3/ZExX/3Vib/9rV2n/cVpt/5N6i/+Lc4P/gGd3/1c+Uf8pFCP/Mh0q/zogJP8qFR3/PCU3/1IyRv+UWkT/XTUw/zslLf9KMjz/XENQ/2dNXP9tUGD/YkVV/29PYf9+Xm7/fl9y/4RkeP9mQ1n/UTJE/0osPf8pEiD/Lhkl/zYhMv9RNEH/kVZB/3xIPP9GJi//NRsn/0UmNP9QLzz/XThD/2xCTf9rQE3/WzVG/1gxRP9aMkT/XzhK/186S/9dOEz/Sis8/zUdK/9CJzj/b0dN/4FKNf+FTDf/d0Q//104Q/9iPEb/cEVP/3NGUP94SFD/cENN/2M7TP9mPE//c0dV/3JHU/9wRlT/bkRV/184Sv9TMkT/YTxN/4hUS/99RC//f0Yx/4dMNf+QVEf/hlJV/4FNVv+ATVX/az9K/2M6Rv9jO0v/YjtL/21CUP95S1f/fE9Z/3hOWf94TFv/ekxZ/4hTTv+aXEb/gEYx/4NIMv+ESjH/iUsz/5RWRf+KUlD/XDI3/1EvNf9aNkD/UC47/1AvPv9hO0n/c0dS/3tOV/+CVFz/lFxW/5xdTf+dXEf/m1tG/4FIMv+ESTH/iEwz/4lONv+PUTn/hEs5/0AbFv8pEhP/SSkx/0AkL/89IjD/VDE8/2E6QP99Tk3/lFpL/5lcRf+fXkj/n1xI/5xaRv+ESTL/hkoy/4pLM/+MTjb/jVA4/5JUO/9gLyD/Jw4N/zsgJv81HCT/Mxol/z0gKv9aMS7/j1dB/5ZbQv+ZW0b/n15J/51bRv+bWkX/iEsy/4pNNP+MTjb/j1A3/5BROP+RUTn/SCAW/yINDv8wGR3/PCMq/08tOv9HJTT/TSgn/5lfR/+aXUT/mltF/5tbRv+aWUT/mllE/4tNNf+NUDb/j1I3/5FSOP+SUzr/lFI8/0YeFv8hDQ3/OyEn/0wrN/9BICv/Sik4/0IhLP9rPjH/mF1G/5haQ/+XWET/l1dC/5dZQ/+KTzX/jVA2/49TNv+RUzj/klM6/5ZUPP9LIRb/Ig4N/0MlLP9OKTj/QSAq/0wrOf9AHy7/VTEp/5leRv+VWED/llhC/5dYQ/+ZWUT/jE41/49QN/+RVDf/lFY5/5NWOf+YVzv/TiUW/yINCv9FJin/RiQr/0kmLv9EICr/KxMZ/2E7Mf+cX0b/lVhA/5haQv+aWkb/mltF/49SOP+TVDn/lFY4/5RXOP+UVjj/mVg+/1srHf8oDQ3/MBQU/ysQEf8rEhL/KhES/yMPDf9sRDb/nF9F/5daQv+ZW0P/l1hE/5taRP+RVDn/k1U6/5FVOf+UVjv/lFY4/5hYPf+ESDT/PRgR/ywSD/8vEhD/LRMS/zAUFP81GRX/hlVB/5teQ/+bXET/mVpD/5ZXQv+XWEP/j1U7/5FVO/+QVTv/kFU8/5JXPP+TWDz/mVxA/3pEL/9BHBX/NhcT/zYZFP8yFRL/Xzgt/5lgR/+YXUT/ml1G/5lbRv+XWUL/mFpE/wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
        public static string setting_path = "";

        public Form1()
        {
            InitializeComponent();
        }       
        private void START_STOP_BTN_Click(object sender, EventArgs e)
        {
            if (START_STOP_BTN.Text == "啟動")
            {
                START_STOP_BTN.Text = "停止";
                START_STOP_BTN.ForeColor = Color.Red;
                run1.Start();

            }
            else
            {
                START_STOP_BTN.Text = "啟動";
                START_STOP_BTN.ForeColor = Color.Black;
                run1.Stop();
            }
        }
        public static void Main()
        {
            Application.Run(new Form1());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + VERSION;
            notifyIcon1.BalloonTipText = "服務停止器已縮小 :D";
            notifyIcon1.BalloonTipTitle = this.Text;
            notifyIcon1.Text = this.Text;
            //my.file_put_contents(my.pwd()+"/"+"icon.ico",my.base64_decode(icon));
            //notifyIcon1.Icon = new Icon("icon.ico");
            this.CenterToScreen();
            //this.Icon = new Icon("icon.ico");
            setting_path = (my.pwd() + "/setting.ini");
            loadTable();          

        }
        public void loadTable()
        {
            
            if (!my.is_file(setting_path))
            {
                string datas = "TBSecSvc.exe,hu,SERVICES.exe,SRSOOBE.exe,unsecapp.exe,TaobaoProtect.exe,SMSvcHost.exe,pcas.exe,MiPhoneHelper.exe,TokenUtility.exe,SearchProtocolHost.exe,SearchFilterHost.exe,DhMachineSvc.exe,aliwssv.exe,WmiPrvSE.exe,Alipaybsm.exe,remoting_host.exe,SearchIndexer.exe,secbizsrv.exe,MsMpEng.exe,DhPluginMgr.exe,WUDFHost.exe,prevhost.exe,SRService.exe,GoogleUpdate.exe,TrustedInstaller.exe,netsession_win.exe,GoogleCrashHandler64.exe,GoogleCrashHandler.exe,NvcSvcMgr.exe,PassThruSvr.exe,armsvc.exe,NisSrv.exe,asusUPCTLoader.exe,nvxdsync.exe,daemonu.exe,nvvsvc.exe,wmpnetwk.exe,nvtray.exe";
                my.file_put_contents(setting_path, datas);
            }

            string data = my.trim(my.b2s(my.file_get_contents(setting_path)));
            string[] mdata = my.explode(",", data);
            Array.Sort<string>(mdata);

            LISTS_DATA.DataSource = null;
            LISTS_DATA.Rows.Clear();

            LISTS_DATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LISTS_DATA.RowHeadersVisible = false;
            LISTS_DATA.ColumnCount = 1;
            LISTS_DATA.Columns[0].Name = "服務名稱";
            //LISTS_DATA.Columns[1].Name = "刪除";
            //LISTS_DATA.Columns[1].Width = 80;
            LISTS_DATA.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //LISTS_DATA.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LISTS_DATA.Columns[0].HeaderCell.Style.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            //LISTS_DATA.Columns[1].HeaderCell.Style.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            //LISTS_DATA.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0, max_i = mdata.Length; i < max_i; i++)
            {
                LISTS_DATA.Rows.Add(mdata[i]);
            }
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "刪除";
                buttons.Text = "刪除";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 1;
            }


            LISTS_DATA.Columns.Add(buttons);
           
        }
        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void LISTS_DATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                string service_name = LISTS_DATA.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("你確定要刪除【" + service_name + "】?", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {
                    //MessageBox.Show(service_name);
                    string data = my.trim(my.b2s(my.file_get_contents(setting_path)));
                    string[] mdata = my.explode(",", data);
                    for (int i = 0, max_i = mdata.Length; i < max_i; i++)
                    {
                        mdata[i] = my.trim(mdata[i]);
                    }
                    Array.Sort<string>(mdata);
                    for (int i = 0, max_i = mdata.Length; i < max_i; i++)
                    {
                        if (mdata[i] == service_name)
                        {
                            List<string> list = new List<string>(mdata);
                            list.RemoveAt(i);                            
                            my.file_put_contents(setting_path, my.implode(",", list));
                            loadTable();
                            break;
                        }
                    }
                }                
            }
        }

        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            string result = ShowDialog("請輸入服務名稱，如: 3wa.exe","新增隔檔服務");
            result = my.trim(result);
            if (result != "")
            {
                string data = my.trim(my.b2s(my.file_get_contents(setting_path)));
                string[] mdata = my.explode(",", data);
                for (int i = 0, max_i = mdata.Length; i < max_i; i++)
                {
                    mdata[i] = my.trim(mdata[i]);
                }
                Array.Sort<string>(mdata);
                bool check = false;
                for (int i = 0, max_i = mdata.Length; i < max_i; i++)
                {
                    if (result == mdata[i])
                    {
                        check = true;
                    }
                }
                if (check == false)
                {
                    List<string> arr = new List<string>(mdata);
                    arr.Add(result);
                    arr.Sort();
                    my.file_put_contents(setting_path, my.implode(",", arr));
                    loadTable();
                }
            }                        
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Height=80,Width=200,Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 90 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return textBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = @"功能：Kill Service 執行緒停止機
版本：" + VERSION + @"
作者：羽山秋人 (https://3wa.tw)
說明：
　　如果你的系統有奇怪的 exe，關掉後又一直自
己跑出來，就可以把這個 exe 新增進來，啟動後就
會使用無限迴圈連續關閉。    
";
            MessageBox.Show(message);
        }
    }

}

