using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoguncelleme
{
    public partial class refoupdate : Form
    {
        public refoupdate()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            WebClient refoupdatesistemi = new WebClient();
            refoupdatesistemi.DownloadFile("http://link/uygulama.exe", "C:\\uygulama.exe"); // oto güncelleme
            refoupdatesistemi.Proxy = null;

        }

        private void refoupdate_Load(object sender, EventArgs e)
        {

        }
    }
}
