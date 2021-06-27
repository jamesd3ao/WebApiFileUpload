using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApiFileUpload.Services
{
    public interface IStorageService
    {
        void Upload(IFormFile formFile);
    }
}
