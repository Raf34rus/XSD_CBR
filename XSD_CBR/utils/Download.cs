using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace XSD_CBR.utils
{
    public class Download
    {
        public static string DownloadFile(string Link)
        {
            using (var client = new WebClient())
            {
                try
                {
                    string FolderPath = Path.Combine(Application.UserAppDataPath, "Log"); ; // куда сохранять.      
                    string FullName = FolderPath + Path.GetFileName(Link);
                    client.DownloadFile(new Uri(Link), FullName);
                    Log.Write($"File {FullName} downloaded to {FolderPath}");
                    return FullName;
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message);
                    return string.Empty;
                }
            }
        }

    }
}
