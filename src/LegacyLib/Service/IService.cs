using System.ServiceModel;
using LegacyLib.Dto;

namespace LegacyLib.Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Result CalculateSomething(RequestDto request);
    }
}
