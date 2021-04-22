using Hotel.data.IRepository;
using Hotel.data.StructModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.SqlRepository
{
    public class Filerepo : IFileRepo
    {
        public JsonResponseModel EditImage(string fileName, string oldFileName)
        {
            var client = new RestClient(ConfigurationManager.AppSettings["ApiUrl"]);
            var request = new RestRequest("/api/File/EditFile");
            request.AddParameter("Token", ConfigurationManager.AppSettings["ApiToken"]);
            request.AddParameter("FileName", oldFileName);
            request.AddFile("File", fileName);
            var response = client.Post(request);
            JsonResponseModel res = JsonConvert.DeserializeObject<JsonResponseModel>(response.Content);

            return res;
        }

        public bool RemoveFile(string fileName)
        {
            var client = new RestClient(ConfigurationManager.AppSettings["ApiUrl"]);
            var request = new RestRequest("/api/File/RemoveFile");
            request.AddParameter("Token", ConfigurationManager.AppSettings["ApiToken"]);
            request.AddParameter("FileName", fileName);
            var response = client.Post(request);
            JsonResponseModel res = JsonConvert.DeserializeObject<JsonResponseModel>(response.Content);
            if (res != null && res.obj != null)
            {
                return (bool)res.obj;
            }

            return false;
        }

        public JsonResponseModel UploadImage(string fileName)
        {
            var client = new RestClient(ConfigurationManager.AppSettings["ApiUrl"]);
            var request = new RestRequest("/api/File/UploadFile");
            request.AddParameter("Token", ConfigurationManager.AppSettings["ApiToken"]);
            request.AddFile("File", fileName);
            var response = client.Post(request);
            JsonResponseModel res = JsonConvert.DeserializeObject<JsonResponseModel>(response.Content);
            return res;
        }
    }
}
