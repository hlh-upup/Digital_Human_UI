using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PPTVideo
{
    public partial class FormSet : Form
    {

        string[] arrAudioPath;
        int count;
        private Point mouseLocation;//表示鼠标对于窗口左上角的坐标的负数
        private bool isDragging;//标识鼠标是否按下
        private bool configAudio = false;
        private bool audioOption = false;


        public void CreateArr() 
        {
            arrAudioPath = new string[count];
        }

        public void SetWindowRegion()
        {
            GraphicsPath FormPath;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 20);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            // 左上角  
            path.AddArc(arcRect, 180, 90);
            // 右上角  
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // 右下角  
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // 左下角  
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线  
            return path;
        }

        private int GetOperation(int checkedCount)
        {
            if (checkedCount == checkedListBox1.Items.Count)
            {
                return 1; // 全部勾选
            }
            else if (checkedCount == 0)
            {
                return 2; // 全部未勾选
            }
            else
            {
                return 3; // 部分勾选
            }
        }

        private bool DetectorWav()
        {
            bool result = true;
            for (int i = 0; i < count; i++)
            {
                if (arrAudioPath[i] == null)
                {
                    MessageBox.Show($"第{i + 1}页的音频没有上传", "提示");
                    result = false;
                }
            }
            if (result)
            {
                return true;
            }
            return false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormSet()
        {
            InitializeComponent();
            SetWindowRegion();
        }
        public void AddSelectNumberAudio()
        {
            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                string s = $"第{i + 1}页添加音频";
                row.Cells[0].Value = s;
                row.Cells[1].Value = "选择";
                this.dataGridView1.Rows.Add(row);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Program.fm.Show();
            this.Close();
        }

        public void AddSelectNumberPerson()
        {
            for (int i = 0; i < count; i++)
            {
                string s = $"第{i + 1}页添加数字人";
                checkedListBox1.Items.Add(s);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (configAudio)
            {
                // 初始化字典
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                int checkedCount = 0;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        //Console.WriteLine($"{i}被勾选了");

                        string index = $"{i}";
                        string value = "True";
                        checkedCount++; // 勾选的项计数增加
                                        // 添加键值对到字典
                        dictionary.Add(index, value);

                    }
                    else
                    {
                        string index = $"{i}";
                        string value = "False";
                        // 添加键值对到字典
                        dictionary.Add(index, value);
                    }
                }

                global.intoDigitalOperation = GetOperation(checkedCount);

                Program.File.DictDataSave(dictionary, "./Data/PeopleLocation.json");
                JObject jsonObject = Program.File.ReadJsonData("./Data/PeopleLocation.json");

                var json = new
                {
                    User = Program.Flask.m_user,
                    People_Location = jsonObject
                };
                string jsonData = JsonConvert.SerializeObject(json);

                if (Program.Flask.SendPeopleLocation(jsonData))
                {
                    MessageBox.Show("配置完成", "提示");
                    global.videoConfig = true;

                    this.DialogResult = DialogResult.OK;
                    //关闭
                    this.Close();
                }
                else
                {
                    MessageBox.Show("发送失败", "提示");
                }
            }
            else
            {
                MessageBox.Show("请配置音频", "提示");
            }
               
        }
        /// <summary>
        /// 使DataGridView的列自适应宽度
        /// </summary>
        /// <param name="dgViewFiles"></param>
        private void AutoSizeColumn(DataGridView dgViewFiles)
        {
            int width = 0;
            //使列自使用宽度
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < dgViewFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                dgViewFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += dgViewFiles.Columns[i].Width;
            }

            if (width > dgViewFiles.Size.Width)
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            dgViewFiles.Columns[1].Frozen = true;
        }
        private void FormSet_Load(object sender, EventArgs e)
        {
            //AutoSizeColumn(dataGridView1);



            dataGridView1.AllowUserToResizeColumns = false;


            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.EnableHeadersVisualStyles = false;//需要
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));


            //读取JSON文件
            string jsonString = File.ReadAllText(@"./Data/comments.json");

            // 解析JSON
            JObject json = JObject.Parse(jsonString);
            count = json.Count;
            CreateArr();
            AddSelectNumberPerson();
            AddSelectNumberAudio();

        }



        private void FormSet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocation = new Point(-e.X, -e.Y);
                //表示鼠标当前位置相对于窗口左上角的坐标，
                //并取负数,这里的e是参数，
                //可以获取鼠标位置
                isDragging = true;//标识鼠标已经按下
            }
        }

        private void FormSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newMouseLocation = MousePosition;
                //获取鼠标当前位置
                newMouseLocation.Offset(mouseLocation.X, mouseLocation.Y);
                //用鼠标当前位置加上鼠标相较于窗体左上角的
                //坐标的负数，也就获取到了新的窗体左上角位置
                Location = newMouseLocation;//设置新的窗体左上角位置
            }
        }

        private void FormSet_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;//鼠标已抬起，标识为false
            }
        }


        private void radiusButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void radiusButton2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                mouseLocation = new Point(-e.X, -e.Y);
                //表示鼠标当前位置相对于窗口左上角的坐标，
                //并取负数,这里的e是参数，
                //可以获取鼠标位置
                isDragging = true;//标识鼠标已经按下
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newMouseLocation = MousePosition;
                //获取鼠标当前位置
                newMouseLocation.Offset(mouseLocation.X, mouseLocation.Y);
                //用鼠标当前位置加上鼠标相较于窗体左上角的
                //坐标的负数，也就获取到了新的窗体左上角位置
                Location = newMouseLocation;//设置新的窗体左上角位置
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (isDragging)
            {
                isDragging = false;//鼠标已抬起，标识为false
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击button按钮事件
            if (dataGridView1.Columns[e.ColumnIndex].Name == "upload" && e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "音频文件(*.mp3;*.wav;*.wma;*.aac;*.flac)|*.mp3;*.wav;*.wma;*.aac;*.flac|所有文件(*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    arrAudioPath[e.RowIndex] = fileDialog.FileName;//返回文件的完整路径               
                }
            }      
 
        }

        private void radiusButton3_Click(object sender, EventArgs e)
        {
            if (DetectorWav())
            {
                configAudio = true;
                audioOption = false;
                for (int i = 0; i < count; i++)
                {
                    string wavName = $"{i}.wav";
                    var json = new
                    {
                        User = Program.Flask.m_user,
                        Audio_Name = wavName
                    };
                    string jsonData = JsonConvert.SerializeObject(json);
                    Program.Flask.SendInsertWav(jsonData, arrAudioPath[i]);
                }
                MessageBox.Show("上传成功", "提示");
            }
        }

        private void radiusButton4_Click(object sender, EventArgs e)
        {
            configAudio = true;
            audioOption = true;
            global.useModelAudio = true;
            MessageBox.Show("选择成功，现使用模型生成声音，讲解内容为PPT内的批注", "提示");
        }
    }
}
