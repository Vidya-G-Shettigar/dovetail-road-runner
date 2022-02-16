using System.Linq;
using System.Collections;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderQuestions;
using DomainModel =  Agents.VictorInsurance.ApiProvider.Infrastructure.Models.ApiProviderQuestion;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using System;

namespace Agents.VictorInsurance.Business.ApiProvider.Services.Services.ApiProviderQuestion
{
    public class  ApiProviderQuestionService :IApiProviderQuestionService
    {

        private readonly IMapper _mapper;
        public ApiProviderQuestionService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    


        public static List<DomainModel.ApiProviderQuestion> questionsets = new List<DomainModel.ApiProviderQuestion>
{
        new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion1"
        },
        new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion2"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion3"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion4"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion5"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion6"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion7"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion8"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion9"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion10"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion11"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion12"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion13"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion14"
        },new DomainModel.ApiProviderQuestion()
        {
            api_path_code = "Quote",response_body = "<response_body>",requested_on_datetime = Convert.ToDateTime("10/01/2011"),
              question_id = "AcceptabilityQuestion15"
        },
       
       
};
        

             public IList<DomainModel.ApiProviderQuestion> GetQuestionSets(DomainModel.ApiProviderQuestionSearchModel questionsetSearchModel){
               IEnumerable<DomainModel.ApiProviderQuestion> result = questionsets;
              
              
              return result?.ToList();
        }

       
    }
}