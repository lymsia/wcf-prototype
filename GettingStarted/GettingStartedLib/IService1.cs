using GettingStartedLib.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace GettingStartedLib
{
    [ServiceContract]
    public interface MyService
    {
        [OperationContract]
        int List(string name);
        [OperationContract]
        bool Add(string name, string password);
        [OperationContract]
        bool Update(string name, string password);
        [OperationContract]
        bool Delete(int id);
    }
}
