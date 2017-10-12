using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo01_TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 100;
                int b = 0;
                tb_log.Text = "计算结果是：" + (a / b).ToString();
            }
            catch(Exception ex)
            {
                tb_log.Text = "出现异常："+ex.Message;
            }
            tb_log.Text += "\r\n" + "try...catch之后的程序正常按顺序执行";
        }
    }
}
