using System.Collections.Generic;
namespace Agents.VictorInsurance.BuildingBlocks.Bootstrapper.Model.ResponseModel
{
    public class BaseResponseModel<TModel> where TModel : class
    {

    }

    public class ResultRecords<TModel> where TModel : class
    {
        public IEnumerable<TModel> MyProperty { get; set; }
        public int page { get; set; }
        public string Nextpage { get; set; }
        public string PreviousPage { get; set; }
    }
}