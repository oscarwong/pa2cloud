using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Diagnostics;

namespace WebRole1
{
    /// <summary>
    /// Summary description for obtain
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class obtain : System.Web.Services.WebService
    {

        public static Trie trie = new Trie();
        public PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        [WebMethod]
        public void GetStorage()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                ConfigurationManager.AppSettings["StorageConnectionString"]);

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClient.GetContainerReference("pa2");

            CloudBlockBlob blob2 = container.GetBlockBlobReference("newtitles.txt");

            string line = null;
            using (StreamReader sr = new StreamReader(blob2.OpenRead()))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (this.ramCounter.NextValue() >= 400000)
                        break;
                    trie.insertWord(line);
                }
            }
        }
    }
}
