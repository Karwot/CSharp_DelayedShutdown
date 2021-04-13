using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace DelayedShutdown
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.netflix.com/watch/60029681?trackId=14170286&tctx=2%2C1%2C3d17e414-6126-4631-b968-5b0a8fe90ede-44140729%2Ca542a595-7d36-4a9c-a0ec-0f2e2a422fbc_77078313X3XX1617997548342%2Ca542a595-7d36-4a9c-a0ec-0f2e2a422fbc_ROOT%2C");
            XPathNavigator docNav = doc.CreateNavigator();
            string xpath = "/html/body/div[2]/div/div/div[1]/div/div/div[2]/div/div[3]/div/div[5]/div[2]/div[1]/div/div[2]/time";
            XPathNavigator node = docNav.SelectSingleNode(xpath);

            if (node != null)
            {
                MessageBox.Show("result:" + node.Value);
            }
            else
            {
                MessageBox.Show("no result");
            }*/

        }
    }
}
