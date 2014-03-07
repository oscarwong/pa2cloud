using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebRole1
{
    /// <summary>
    /// Summary description for test
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class test : System.Web.Services.WebService
    {
        public static Trie trie = new Trie();

        [WebMethod]
        public void insert()
        {
            string line = null;
            using (FileStream fs = File.Open(@"C:\Users\iguest\Desktop\test.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    trie.insertWord(line);
                }
            }
        }

        [WebMethod]
        public List<string> Read(string _userinput)
        {
            return trie.searchPrefix(_userinput);
        }
    }
}
