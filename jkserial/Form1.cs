using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
namespace jkserial
{
    public partial class Form1 : Form
    {
        private long receive_count = 0; //接收字节计数，相当于全局变量
        private long send_count = 0;    //发送字节计数
        private StringBuilder sb = new StringBuilder();
        private DateTime current_time = new DateTime();
        private static ILog log = log4net.LogManager.GetLogger("Test");
        private void InitGridView()
        {
            /*
            dgvDataList.ColumnCount = 4;
            dgvDataList.Columns[0].Name = "学号";
            dgvDataList.Columns[1].Name = "姓名";
            dgvDataList.Columns[2].Name = "性别";
            dgvDataList.Columns[3].Name = "联系方式";*/
        }
        public Form1()
        {
            InitializeComponent();
            InitGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSerialNumber.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            cmbSerialNumber.SelectedIndex = 0;
            cmbBaudrate.SelectedIndex = 1;
            cmbDataBit.SelectedIndex = 1;
            cmbCheckBit.SelectedIndex = 0;
            cmbStopBit.SelectedIndex = 0;
            btnSend.Enabled = false;
            radRxAsc.Checked = true;
            radTxAsc.Checked = true;
            nudInterval.Value = 1000;
            timer2.Interval = 1000;
            timer2.Start();
            log.Info("窗体加载");
        }

        private void btnSwitchSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)      //如果串口处于开启状态
                {
                    serialPort1.Close();    //关闭串口
                    btnSwitchSerial.Text = "打开串口";
                    //btnSwitchSerial.BackColor = Color.ForestGreen;
                    cmbSerialNumber.Enabled = true;
                    cmbBaudrate.Enabled = true;
                    cmbDataBit.Enabled = true;
                    cmbCheckBit.Enabled = true;
                    cmbStopBit.Enabled = true;
                    txtSendData.Text = "";
                    txtSerialData.Text = "";
                    lblSerialSta.Text = "串口已关闭";
                    lblSerialSta.ForeColor = Color.Red;
                    timer2.Interval = 1000;
                    timer2.Start();
                }
                else
                {
                    cmbSerialNumber.Enabled = false;
                    cmbBaudrate.Enabled = false;
                    cmbDataBit.Enabled = false;
                    cmbCheckBit.Enabled = false;
                    cmbStopBit.Enabled = false;
                    serialPort1.PortName = cmbSerialNumber.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaudrate.Text);
                    serialPort1.DataBits = Convert.ToInt16(cmbDataBit.Text);
                    if (cmbCheckBit.Text.Equals("NONE"))
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                    }
                    else if (cmbCheckBit.Text.Equals("ODD"))
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    }
                    else if (cmbCheckBit.Text.Equals("EVEN"))
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                    }

                    if (cmbStopBit.Text.Equals("1"))
                    {
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    }
                    else if (cmbStopBit.Text.Equals("1.5"))
                    {
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    }
                    else if (cmbStopBit.Text.Equals("2"))
                    {
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    }
                    serialPort1.Open(); //打开串口
                    btnSwitchSerial.Text = "关闭串口";
                    //btnSwitchSerial.BackColor = Color.Firebrick;
                    lblSerialSta.Text = "串口已打开";
                    lblSerialSta.ForeColor = Color.Green;
                    btnSend.Enabled = true;
                    timer2.Stop();
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                cmbSerialNumber.Items.Clear();
                cmbSerialNumber.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                btnSwitchSerial.Text = "打开串口";
                btnSwitchSerial.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                cmbSerialNumber.Enabled = true;
                cmbBaudrate.Enabled = true;
                cmbDataBit.Enabled = true;
                cmbCheckBit.Enabled = true;
                cmbStopBit.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int send_num = 0;
            byte[] temp = new byte[1];
            try
            {
                if (serialPort1.IsOpen)
                {
                    if(chkDisSend.Checked)
                    {
                        txtSerialData.AppendText(txtSendData.Text);
                    }
                    if(radTxHex.Checked)
                    {
                        //以HEX模式发送
                        //以正则表达式将用户输入字符串中的十六进制字符匹配出来
                        string buf = txtSendData.Text;
                        string pattern = @"\s";
                        string replacement = "";
                        Regex rgx = new Regex(pattern);
                        string send_data = rgx.Replace(buf, replacement);
                        //不发送新行
                        send_num = (send_data.Length - send_data.Length % 2) / 2;
                        for (int i = 0; i < send_num; i++)
                        {
                            temp[0] = Convert.ToByte(send_data.Substring(i * 2, 2), 16);
                            serialPort1.Write(temp, 0, 1);
                        }
                        //如果用户输入的数据为奇数
                        if ((send_data.Length % 2) != 0)
                        {
                            temp[0] = Convert.ToByte(send_data.Substring(send_data.Length - 1, 1), 16);
                            serialPort1.Write(temp, 0, 1);
                            send_num++;
                        }
                        if (chkNewLine.Checked)
                        {
                            serialPort1.WriteLine("");
                        }
                    }
                    else
                    {
                        //以ASCII码发送
                        if (chkNewLine.Checked)
                        {
                            serialPort1.WriteLine(txtSendData.Text);
                            send_num = txtSendData.Text.Length + 2;
                        }
                        else
                        {
                            serialPort1.Write(txtSendData.Text);
                            send_num = txtSendData.Text.Length;
                        }
                    }
                    send_count += send_num;
                    lblTxNum.Text = "Tx:" + send_count.ToString() + "Bytes";
                    //记录到历史记录中
                    if (cmbSendList.Items.Contains(txtSendData.Text) == true)
                    {
                        return;
                    }
                    else
                    {
                        cmbSendList.Items.Add(txtSendData.Text);
                    }
                    log.Info("发送一次数据");
                }
            }
            catch (Exception ex)
            {
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                cmbSerialNumber.Items.Clear();
                cmbSerialNumber.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                btnSwitchSerial.Text = "打开串口";
                //btnSwitchSerial.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                cmbSerialNumber.Enabled = true;
                cmbBaudrate.Enabled = true;
                cmbDataBit.Enabled = true;
                cmbStopBit.Enabled = true;
                cmbCheckBit.Enabled = true;
            }
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int num = serialPort1.BytesToRead;  //获取接收缓冲区的字节数
            byte[] received_buf = new byte[num];    //声明一个大小为num字节的数据用于存放读取的byte形数据
            receive_count += num;               //接收字节计数变量增加num
            serialPort1.Read(received_buf, 0, num);
            sb.Clear();//清空字符串构造器
            //遍历数组进行字符串转换及拼接
            if (radRxHex.Checked)
            {
                foreach (byte b in received_buf)
                {
                    sb.Append(b.ToString("X2") + ' ');
                }
            }
            else
            {
                sb.Append(Encoding.ASCII.GetString(received_buf));
            }
            try
            {
                //因为要访问UI资源，所以需要使用invoke方式同步ui
                this.Invoke((EventHandler)(delegate
                {
                    if (chkDisTime.Checked)
                    {
                        //显示时间
                        current_time = System.DateTime.Now;
                        txtSerialData.AppendText("[" + current_time.ToString("HH:mm:ss") + "] " + sb.ToString());
                    }
                    else
                    {
                        txtSerialData.AppendText(sb.ToString());
                    }
                    lblRxNum.Text = "Rx: " + receive_count.ToString() + "Bytes";
                }
                )
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClrData_Click(object sender, EventArgs e)
        {
            txtSerialData.Text = "";
            txtSendData.Text = "";
            receive_count = 0;
            send_count = 0;
            lblRxNum.Text = "Rx: " + receive_count.ToString() + "Bytes";
            lblTxNum.Text = "Tx:" + send_count.ToString() + "Bytes";
        }

        private void chkAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSend.Checked)
            {
                nudInterval.Enabled = false;
                timer1.Interval = (int)nudInterval.Value;
                timer1.Start();
                lblSerialSta.Text = "串口已打开" + "自动发送中...";
            }
            else
            {
                //自动功能未选中
                nudInterval.Enabled = true;
                timer1.Stop();
                lblSerialSta.Text = "串口已打开";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //定时时间到
            btnSend_Click(btnSend, new EventArgs());
        }
        private bool search_port_is_exist(String item, String[] port_list)
        {
            for(int i=0; i< port_list.Length; i++)
            {
                if(port_list[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        private void update_serial_list()
        {
            try
            {
                //搜索串口
                String[] cur_port_list = System.IO.Ports.SerialPort.GetPortNames();

                //刷新串口列表
                int count = cmbSerialNumber.Items.Count;
                if(count == 0)
                {
                    cmbSerialNumber.Items.AddRange(cur_port_list);
                    return;
                }
                else
                {
                    //判断有无新的串口插入
                    for(int i=0; i<cur_port_list.LongLength; i++)
                    {
                        if(cmbSerialNumber.Items.Contains(cur_port_list[i])==false)
                        {
                            //找到新插入串口，添加到combox中
                            cmbSerialNumber.Items.Add(cur_port_list[i]);
                        }
                    }

                    //判断有无串口拔出
                    for (int i = 0; i < count; i++)
                    {
                        if(search_port_is_exist(cmbSerialNumber.Items[i].ToString(),cur_port_list)==false)
                        {
                            //找到已经被拔掉的串口，从combox中移出
                            cmbSerialNumber.Items.RemoveAt(i);
                        }
                    }
                }
                //如果当前选中项未空，则默认选择第一项
                if(cmbSerialNumber.Items.Count>0)
                {
                    if(cmbSerialNumber.Text.Equals(""))
                    {
                        //软件刚启动时，列表项的文本值为空
                        cmbSerialNumber.Text = cmbSerialNumber.Items[0].ToString();
                    }
                }
                else
                {
                    //无可用列表，清空文本值
                    cmbSerialNumber.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            update_serial_list();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            //获取当前接收区的内容
            String recv_data = txtSerialData.Text;
            if(recv_data.Equals(""))
            {
                MessageBox.Show("接收数据为空，无需保存!");
                return;
            }
            //获取当前时间
            current_time = System.DateTime.Now;
            String filename = "log" + "_" + current_time.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
            try
            {
                //创建FileStream类实例
                FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                //将字符串转换为字符数组
                byte[] bytes = Encoding.UTF8.GetBytes(recv_data);
                //向文件中写入字节数组
                fileStream.Write(bytes, 0, bytes.Length);
                //刷新缓冲区
                fileStream.Flush();
                //关闭流
                fileStream.Close();
                //提示用户
                MessageBox.Show("日志已保存！(" + filename + ")");
            }
            catch(Exception ex)
            {
                MessageBox.Show("保存异常！(" + ex.ToString() + ")");
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            string file;
            //弹出文件选择框供用户选择
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择要加载的文件(文本格式)";
            dialog.Filter = "所有文件(*.*)|*.*";
            if(dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
                //txtSerialData.AppendText(file);
            }
            else
            {
                return;
            }

            try
            {
                //清空发送区
                txtSendData.Text = "";
                //使用StreamReader来读取文件
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    //从文件读取并显示行，直到文件的末尾
                    while((line=sr.ReadLine())!=null)
                    {
                        line = line + "\r\n";
                        txtSendData.AppendText(line);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载文件异常！(" + ex.ToString() + ")");
            }
        }

        private void cmbSendList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSendData.Text = cmbSendList.SelectedItem.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Links[this.linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = "http://www.jinka.cn/";
            try
            {
                System.Diagnostics.Process.Start("msedge.exe", targetUrl);
                return;
            }
            catch(Exception)
            {

            }
            try
            {
                System.Diagnostics.Process.Start("firefox.exe", targetUrl);
                return;
            }
            catch (Exception)
            {

            }
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", targetUrl);
                return;
            }
            catch (Exception)
            {

            }
            
            try
            {
                System.Diagnostics.Process.Start("iexplore.exe", targetUrl);
                return;
            }
            catch (Exception)
            {

            }
        }
    }
}
