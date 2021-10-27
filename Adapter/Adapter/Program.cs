using Adapter.Apis;
using Adapter.Adapters;
using Adapter.Const;
using Adapter.Sources;
using System;
using Adapter.Services;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSourceAdapter fileSourceAdapter = new FileSourceAdapter(SystemConstants.FilePath, new FileSource());
            ApiSourceAdapter apiSourceAdapter = new ApiSourceAdapter(new ApiSource());


            EmployeeService obj = new EmployeeService(fileSourceAdapter);
            obj.ListEmployees();
            obj = new EmployeeService(apiSourceAdapter);
            obj.ListEmployees();
        }
    }
}
