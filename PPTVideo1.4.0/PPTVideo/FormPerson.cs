using Newtonsoft.Json;
using System;

using System.Drawing;
using System.Windows.Forms;

namespace PPTVideo
{
    public partial class FormPerson : Form
    {

        string m_imagePath = null;
        string m_videoPath = null;

        bool m_enhancers = false;
        double value = 1.0;

        bool m_openEnhancers = true;
        bool m_openExpression = true;



        public FormPerson()
        {
            InitializeComponent();
            // 获取主屏幕的DPI设置
            float dpiX, dpiY;
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }

            // 计算缩放比例
            float scale = dpiX / 90.0f;  // 96 DPI是Windows的默认DPI

            axWindowsMediaPlayer1.Size = new Size((int)(250 * scale), (int)(220 * scale));
            axWindowsMediaPlayer1.uiMode = "none";


        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYes.Checked)
            {
                cbNO.Checked = false;
                m_openEnhancers = false;

                m_enhancers = true;
            }
        }

        private void cbNO_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNO.Checked)
            {
                cbYes.Checked = false;
                m_openEnhancers = false;

                m_enhancers = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            m_openExpression = false;
            double expressionValue = trackBar1.Value / 10;
            value = (expressionValue / 10) + 1;

            lblNumber.Text = value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 创建一个OpenFileDialog对象
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";

            // 如果用户选择了一个文件
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                m_imagePath = openFileDialog.FileName;

                // 将图片显示在pictureBox1上
                pictureBox1.Image = Image.FromFile(m_imagePath);
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {   
            //没有动作
            if (global.digitalMotion == 1)
            {
                if (Program.Flask.m_user == null)
                {
                    MessageBox.Show("还没有登录，请先登录！", "提示");
                }
                else if (m_openEnhancers)
                {
                    MessageBox.Show("没有选择是否脸部增强", "提示");
                }
                else if (m_openExpression)
                {
                    MessageBox.Show("没有选择表达增强", "提示");
                }
                else if (m_imagePath == null)
                {
                    MessageBox.Show("没有上传教师形象", "提示");
                }
                else
                {
                    global.m_enhancer = m_enhancers;
                    global.m_expression_scale = value;

                    string imgDataBase64 = Program.File.EncodeBase64(m_imagePath);
                    Program.Flask.SetImagePath(imgDataBase64);

                    var json = new
                    {
                        User = Program.Flask.m_user,
                        Img = Program.Flask.m_imageBase64
                    };
                    string jsonData = JsonConvert.SerializeObject(json);

                    if (Program.Flask.SendImage(jsonData))
                    {
                        MessageBox.Show("提交成功", "提示");
                        global.numberPersonConfig = false;
                    }
                    else
                    {
                        MessageBox.Show("提交失败", "提示");
                    }
                }
            }

            //有动作
            else if (global.digitalMotion == 2)
            {
                if (m_openEnhancers)
                {
                    MessageBox.Show("没有选择是否脸部增强", "提示");
                }
                else if (m_videoPath == null)
                {
                    MessageBox.Show("没有上传教师形象", "提示");
                }
                else
                {
                    global.m_enhancer = m_enhancers;

                    var json = new
                    {
                        User = Program.Flask.m_user,
                    };

                    string jsonData = JsonConvert.SerializeObject(json);
                    if (Program.Flask.SendTeacherVideo(jsonData, m_videoPath))
                    {
                        MessageBox.Show("提交成功", "提示");
                        global.numberPersonConfig = false;
                    }
                    else
                    {
                        MessageBox.Show("提交失败", "提示");
                    }
                }
            }
        }

        private void tabPersonMotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPersonMotion.SelectedIndex == 0)
            {
                global.digitalMotion = 1;
                m_openEnhancers = true;
            }
            else if (tabPersonMotion.SelectedIndex == 1)
            {
                global.digitalMotion = 2;
                m_openEnhancers = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                m_openEnhancers = false;

                m_enhancers = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                m_openEnhancers = false;

                m_enhancers = false;
            }
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            // 创建一个OpenFileDialog对象
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files (*.mp4)|*.mp4";

            // 如果用户选择了一个文件
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                m_videoPath = openFileDialog.FileName;

                // 播放视频
                axWindowsMediaPlayer1.URL = m_videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play(); // 开始播放视频
            }
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
