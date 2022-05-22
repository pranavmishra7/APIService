using APIService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIService.Service.interfaces
{
    public interface IdataService
    {
        bool AddData(FormData formData);
        List<FormData> Read();
    }
}
