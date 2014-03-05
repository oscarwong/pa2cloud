using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace pa2retry
{
    /// <summary>
    /// Summary description for Function
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Function : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> HelloWorld(string input)
        {
            Trie trie = new Trie();
            trie = obtain.GetStorage();
            return trie.searchPrefix(input);
        }
    }
}
