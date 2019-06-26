using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Helper;



namespace QRCodeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessagingToolkit.QRCode.Codec.QRCodeEncoder xencoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder(); //建立 encoder
            string xcontent = "https://www.baidu.com";// "wgscd你好啊";
            System.Drawing.Bitmap qrcode = xencoder.Encode(xcontent); //將內容轉碼成 QR code
            qrcode.Save("qrcode_1.png"); //把 QRcode 另存為 PNG 圖檔,並放置於 images 資料夾底下
           



        }
    }
}
