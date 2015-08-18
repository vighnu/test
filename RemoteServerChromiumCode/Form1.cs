using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemoteServerManager.Ui.UserControls;

namespace RemoteServerManager {
  public partial class Form1 : Form {

    public Form1() {
      InitializeComponent();
     
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string url = @"local://web/index.html";// @"file:///L:/Wales.co.in/index.html";
      var chrome = new ChromeWebControl(url);
      chrome.Dock = DockStyle.Fill;
      chrome.Show();
      this.Controls.Add(chrome);
      
      //string page = string.Format("{0}HTMLEmbeddedResources/html/BootstrapExample.html", GetAppLocation());

     // m_chromeBrowser.Load(page);
    }
  }
}
