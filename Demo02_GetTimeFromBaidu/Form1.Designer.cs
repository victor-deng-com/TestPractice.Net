namespace Demo02_GetTimeFromBaidu
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_log = new System.Windows.Forms.TextBox();
            this.btn_getTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(13, 13);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(502, 276);
            this.tb_log.TabIndex = 0;
            // 
            // btn_getTime
            // 
            this.btn_getTime.Location = new System.Drawing.Point(183, 316);
            this.btn_getTime.Name = "btn_getTime";
            this.btn_getTime.Size = new System.Drawing.Size(105, 42);
            this.btn_getTime.TabIndex = 1;
            this.btn_getTime.Text = "获取时间";
            this.btn_getTime.UseVisualStyleBackColor = true;
            this.btn_getTime.Click += new System.EventHandler(this.btn_getTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 392);
            this.Controls.Add(this.btn_getTime);
            this.Controls.Add(this.tb_log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button btn_getTime;
    }
}

