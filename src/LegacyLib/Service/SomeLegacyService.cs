using System;
using System.Threading;
using LegacyLib.Dto;


namespace LegacyLib.Service
{
    public class SomeLegacyService: IService
    {
        public Result CalculateSomething(RequestDto request)
        {
            try
            {
                //Thread.Sleep(TimeSpan.FromMilliseconds(10));

                return FakeDataProvider.Instance.GetResult();
                
             }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
