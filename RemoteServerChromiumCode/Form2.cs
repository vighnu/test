using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemoteServerManager.Ui.UserControls;
using CefSharp.WinForms;
namespace RemoteServerManager.Ui {
  public partial class Form2 : Form {
    public Form2() {
      InitializeComponent();
    }
    private ChromeWebControl _webControl;
    private void Form2_Load(object sender, EventArgs e) {
      string url = @"local://web/index2.html";// @"file:///L:/Wales.co.in/index.html";
      _webControl = new ChromeWebControl(url);
      _webControl.Dock = DockStyle.Fill;
      _webControl.Show();
      this.containerPanel.Controls.Add(_webControl);
      _webControl.Browser.RegisterJsObject("callbackObj",new CallbackObjectForJs());
    }

    private void button1_Click(object sender, EventArgs e) {
      this._webControl.Browser.ExecuteScriptAsync(string.Format("alertMe('{0}');", textBox1.Text.Trim()));
    }


    public class CallbackObjectForJs {
      public void showMessage(string msg) {//Read Note
        MessageBox.Show(msg);
      }
    }

  }
}
