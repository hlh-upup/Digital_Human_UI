namespace PPTVideo
{
    partial class FormNumberPerson
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
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.btnResult.Location = new System.Drawing.Point(456, 20);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnResult.Name = "btnResult";
            this.btnResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResult.Size = new System.Drawing.Size(157, 49);
            this.btnResult.TabIndex = 14;
            this.btnResult.Text = "效果查看";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudio.FlatAppearance.BorderSize = 0;
            this.btnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudio.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.btnAudio.Location = new System.Drawing.Point(267, 20);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAudio.Size = new System.Drawing.Size(157, 49);
            this.btnAudio.TabIndex = 13;
            this.btnAudio.Text = "人物声音";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(119)))));
            this.btnPerson.Location = new System.Drawing.Point(79, 20);
            this.btnPerson.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(157, 49);
            this.btnPerson.TabIndex = 12;
            this.btnPerson.Text = "人物形象";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 408);
            this.panel2.TabIndex = 11;
            // 
            // FormNumberPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 523);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormNumberPerson";
            this.Text = "FormNumberPerson";
            this.Load += new System.EventHandler(this.FormNumberPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Panel panel2;
    }
}