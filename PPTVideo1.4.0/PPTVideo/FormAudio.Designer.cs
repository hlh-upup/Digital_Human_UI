namespace PPTVideo
{
    partial class FormAudio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new PPTVideo.RadiusButton();
            this.cbGirl = new System.Windows.Forms.CheckBox();
            this.cbMan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radiusButton1 = new PPTVideo.RadiusButton();
            this.radiusButton11 = new PPTVideo.RadiusButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.cbBaseAi = new System.Windows.Forms.CheckBox();
            this.cbTrainAi = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new PPTVideo.RadiusButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.cbGirl);
            this.groupBox2.Controls.Add(this.cbMan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.groupBox2.Location = new System.Drawing.Point(2, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(283, 262);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预训练声音选择:";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.IsRoundCorner = true;
            this.btnPlay.Location = new System.Drawing.Point(67, 176);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RoundRadius = 50;
            this.btnPlay.Size = new System.Drawing.Size(141, 46);
            this.btnPlay.TabIndex = 21;
            this.btnPlay.Text = "试听";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbGirl
            // 
            this.cbGirl.AutoSize = true;
            this.cbGirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGirl.Location = new System.Drawing.Point(166, 108);
            this.cbGirl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGirl.Name = "cbGirl";
            this.cbGirl.Size = new System.Drawing.Size(51, 26);
            this.cbGirl.TabIndex = 12;
            this.cbGirl.Text = "女";
            this.cbGirl.UseVisualStyleBackColor = true;
            this.cbGirl.CheckedChanged += new System.EventHandler(this.cbGirl_CheckedChanged);
            // 
            // cbMan
            // 
            this.cbMan.AutoSize = true;
            this.cbMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMan.Location = new System.Drawing.Point(67, 108);
            this.cbMan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMan.Name = "cbMan";
            this.cbMan.Size = new System.Drawing.Size(51, 26);
            this.cbMan.TabIndex = 11;
            this.cbMan.Text = "男";
            this.cbMan.UseVisualStyleBackColor = true;
            this.cbMan.CheckedChanged += new System.EventHandler(this.cbMan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "声色选择:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radiusButton1);
            this.groupBox1.Controls.Add(this.radiusButton11);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.groupBox1.Location = new System.Drawing.Point(305, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 262);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自训练声音选择:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "选择模型:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 13.8F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 26);
            this.comboBox1.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(172, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "参考音频:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "参考文字:";
            // 
            // radiusButton1
            // 
            this.radiusButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.radiusButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiusButton1.FlatAppearance.BorderSize = 0;
            this.radiusButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiusButton1.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radiusButton1.ForeColor = System.Drawing.Color.White;
            this.radiusButton1.IsRoundCorner = true;
            this.radiusButton1.Location = new System.Drawing.Point(80, 176);
            this.radiusButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiusButton1.Name = "radiusButton1";
            this.radiusButton1.RoundRadius = 50;
            this.radiusButton1.Size = new System.Drawing.Size(141, 46);
            this.radiusButton1.TabIndex = 22;
            this.radiusButton1.Text = "试听";
            this.radiusButton1.UseVisualStyleBackColor = false;
            this.radiusButton1.Click += new System.EventHandler(this.radiusButton1_Click);
            // 
            // radiusButton11
            // 
            this.radiusButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.radiusButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiusButton11.FlatAppearance.BorderSize = 0;
            this.radiusButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiusButton11.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radiusButton11.ForeColor = System.Drawing.Color.White;
            this.radiusButton11.IsRoundCorner = true;
            this.radiusButton11.Location = new System.Drawing.Point(176, 120);
            this.radiusButton11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiusButton11.Name = "radiusButton11";
            this.radiusButton11.RoundRadius = 40;
            this.radiusButton11.Size = new System.Drawing.Size(91, 34);
            this.radiusButton11.TabIndex = 46;
            this.radiusButton11.Text = "上传";
            this.radiusButton11.UseVisualStyleBackColor = false;
            this.radiusButton11.Click += new System.EventHandler(this.radiusButton11_Click);
            // 
            // textBox11
            // 
            this.textBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.textBox11.Location = new System.Drawing.Point(21, 122);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(131, 32);
            this.textBox11.TabIndex = 49;
            // 
            // cbBaseAi
            // 
            this.cbBaseAi.AutoSize = true;
            this.cbBaseAi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBaseAi.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaseAi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.cbBaseAi.Location = new System.Drawing.Point(58, 8);
            this.cbBaseAi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBaseAi.Name = "cbBaseAi";
            this.cbBaseAi.Size = new System.Drawing.Size(139, 26);
            this.cbBaseAi.TabIndex = 47;
            this.cbBaseAi.Text = "预训练模型";
            this.cbBaseAi.UseVisualStyleBackColor = true;
            this.cbBaseAi.CheckedChanged += new System.EventHandler(this.cbBaseAi_CheckedChanged);
            // 
            // cbTrainAi
            // 
            this.cbTrainAi.AutoSize = true;
            this.cbTrainAi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTrainAi.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTrainAi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.cbTrainAi.Location = new System.Drawing.Point(365, 8);
            this.cbTrainAi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTrainAi.Name = "cbTrainAi";
            this.cbTrainAi.Size = new System.Drawing.Size(161, 26);
            this.cbTrainAi.TabIndex = 48;
            this.cbTrainAi.Text = "定制训练模型";
            this.cbTrainAi.UseVisualStyleBackColor = true;
            this.cbTrainAi.CheckedChanged += new System.EventHandler(this.cbTrainAi_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IsRoundCorner = true;
            this.btnSubmit.Location = new System.Drawing.Point(176, 332);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.RoundRadius = 50;
            this.btnSubmit.Size = new System.Drawing.Size(214, 50);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "确认提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 418);
            this.Controls.Add(this.cbTrainAi);
            this.Controls.Add(this.cbBaseAi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAudio";
            this.Load += new System.EventHandler(this.FormAudio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadiusButton btnSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbGirl;
        private System.Windows.Forms.CheckBox cbMan;
        private System.Windows.Forms.Label label1;
        private RadiusButton btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private RadiusButton radiusButton11;
        private System.Windows.Forms.TextBox textBox11;
        private RadiusButton radiusButton1;
        private System.Windows.Forms.CheckBox cbBaseAi;
        private System.Windows.Forms.CheckBox cbTrainAi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}