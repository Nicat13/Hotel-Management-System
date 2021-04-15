using Hotel.data.StructModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.IRepository
{
    public interface IFileRepo
    {
        JsonResponseModel UploadImage(string fileName);
        string EditImage(string fileName,string oldFileName);
        bool RemoveFile(string fileName);
    }
}
