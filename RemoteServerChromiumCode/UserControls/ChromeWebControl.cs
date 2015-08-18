using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using RemoteServerManager.Ui.TestCodes;

namespace RemoteServerManager.Ui.UserControls {
  public partial class ChromeWebControl : UserControl {
    static ChromeWebControl()
    {
      RegisterSettings();
    }
    public ChromiumWebBrowser Browser { get; set; }

    public ChromeWebControl(string address) {
      InitializeComponent();
      this.Browser = new ChromiumWebBrowser(address);
     // RegisterSettings();
      this.Browser.Dock = DockStyle.Fill;
      this.Browser.Show();
      
      this.panel1.Controls.Add(this.Browser);
    }

    static void RegisterSettings()
    {
      var settings = new CefSettings();
      settings.RegisterScheme(new CefCustomScheme() {
        SchemeName = LocalSchemeHandlerFactory.SchemeName,
        SchemeHandlerFactory = new LocalSchemeHandlerFactory()
      });
      Cef.Initialize(settings);
    }
  }
}
