using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CefSharp;

namespace RemoteServerManager.Ui.TestCodes {
  public class LocalSchemeHandler : ISchemeHandler {
    public bool ProcessRequestAsync(IRequest request, ISchemeHandlerResponse response, OnRequestCompletedHandler requestCompletedCallback) {
      Uri u = new Uri(request.Url);
      String file = u.Authority + u.AbsolutePath;

      if(File.Exists(file)) {
        Byte[] bytes = File.ReadAllBytes(file);
        response.ResponseStream = new MemoryStream(bytes);
        switch(Path.GetExtension(file)) {
          case ".html":
            response.MimeType = "text/html";
            break;
          case ".js":
            response.MimeType = "text/javascript";
            break;
          case ".png":
            response.MimeType = "image/png";
            break;
          case ".appcache":
          case ".manifest":
            response.MimeType = "text/cache-manifest";
            break;
          default:
            response.MimeType = "application/octet-stream";
            break;
        }
        requestCompletedCallback();
        return true;
      }
      return false;
    }
  }

  public class LocalSchemeHandlerFactory : ISchemeHandlerFactory {
    public ISchemeHandler Create() {
      return new LocalSchemeHandler();
    }

    public static string SchemeName { get { return "local"; } }
  }
}
