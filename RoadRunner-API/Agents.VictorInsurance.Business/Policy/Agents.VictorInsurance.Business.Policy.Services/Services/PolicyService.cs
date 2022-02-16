using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using DomainModel = Agents.VictorInsurance.Business.Policy.Infrastructure.Models.Policy;
using System;
using Agents.VictorInsurance.Business.Policy.Services.Interfaces;

namespace Agents.VictorInsurance.Business.Policy.Services.Services
{
    public class PolicyService : IPolicyService
    {
        private readonly IMapper _mapper;
        public PolicyService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    


        public static IList<DomainModel.Policy> policies = new List<DomainModel.Policy>
{
        new DomainModel.Policy()
        {
            client_name = "REG_WC_TC018", policy_number = "TWC4070022" , business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 4025, status = "Active",  state_code = "AL" , policy_effective_date_datetime = Convert.ToDateTime("10/01/2011"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2011"), quote_proposal_number = 123456 , agent_id = "99999999"
        },
        new DomainModel.Policy()
        {
            client_name = "REG_WC_TC019", policy_number = "TWC4070021", business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user1",premium= 1104, status = "Active",  state_code = "AR" , policy_effective_date_datetime = Convert.ToDateTime("10/01/2011"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2011"), quote_proposal_number = 123457 , agent_id = "99999999"
        },
        new DomainModel.Policy()
        {
            client_name = "REG_WC_TC020", policy_number = "TWC4070022", business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user1",premium= 5595, status = "Active",  state_code = "AR" , policy_effective_date_datetime = Convert.ToDateTime("10/01/2011"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2011"), quote_proposal_number = 123458 , agent_id = "99999999"
        },
         new DomainModel.Policy()
        {
            client_name = "REG_WC_TC025", policy_number = "TWC4070021",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("10/10/2021"),
              created_by = "Test_user1",premium= 20445, status = "Active",  state_code = "TX" , policy_effective_date_datetime = Convert.ToDateTime("1/10/2018"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123459 , agent_id = "99999999"
        },
      new DomainModel.Policy()
        {
            client_name = "REG_WC_TC026", policy_number = "QWC1032839",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 10445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("11/10/2019"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123451 , agent_id = "99999999"
        },
      new DomainModel.Policy()
        {
            client_name = "REG_WC_TC027", policy_number = "QWC1032838",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 5445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("10/10/2017"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123450 , agent_id = "99999999"
        },
      new DomainModel.Policy()
        {
            client_name = "REG_WC_TC028", policy_number = "QWC1032840",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 1445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("08/10/2020"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123452 , agent_id = "99999999"
        },
new DomainModel.Policy()
        {
            client_name = "REG_WC_TC029", policy_number = "QWC1032841",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 20345, status = "Active",  state_code = "AR" , policy_effective_date_datetime = Convert.ToDateTime("11/10/2021"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123453 , agent_id = "99999998"
        },
         new DomainModel.Policy()
        {
            client_name = "REG_WC_TC034", policy_number = "TWC4070046",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("10/10/2021"),
              created_by = "Test_user1",premium= 20445, status = "Active",  state_code = "TX" , policy_effective_date_datetime = Convert.ToDateTime("10/11/2020"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123440 , agent_id = "99999999"
        },
new DomainModel.Policy()
        {
            client_name = "REG_WC_TC033", policy_number = "QWC1032845",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 10445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("09/10/2021"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123441 , agent_id = "99999997"
        },
new DomainModel.Policy()
        {
            client_name = "REG_WC_TC032", policy_number = "QWC1032844",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 5445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("11/09/2021"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123443 , agent_id = "99999999"
        },
new DomainModel.Policy()
        {
            client_name = "REG_WC_TC031", policy_number = "QWC1032843",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 1445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("11/08/2021"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123442 , agent_id = "99999992"
        },
new DomainModel.Policy()
        {
            client_name = "REG_WC_TC030", policy_number = "QWC1032842",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 20345, status = "Active",  state_code = "AR" , policy_effective_date_datetime = Convert.ToDateTime("09/10/2021"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123444, agent_id = "99999999"
        },
         new DomainModel.Policy()
        {
            client_name = "REG_WC_TC035", policy_number = "TWC4070047",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("10/10/2021"),
              created_by = "Test_user1",premium= 10445, status = "Active",  state_code = "TX" , policy_effective_date_datetime = Convert.ToDateTime("11/10/2019"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123445 , agent_id = "99999999"
        },
new DomainModel.Policy()
        {
            client_name = "REG_WC_TC036", policy_number = "QWC1032846",business_line = "Worker Compensation", created_on_datetime = Convert.ToDateTime("8/10/2021"),
              created_by = "Test_user1",premium= 13445, status = "Active",  state_code = "THE" , policy_effective_date_datetime = Convert.ToDateTime("11/10/2018"),
              policy_expiration_date_datetime = Convert.ToDateTime("10/01/2024"), quote_proposal_number = 123446 , agent_id = "99999995"
        }
       

    };

        public IEnumerable<DomainModel.Policy> GetPolicies(DomainModel.PolicySearchModel policySearchModel){
               IEnumerable<DomainModel.Policy> result = policies;
              if(!string.IsNullOrEmpty(policySearchModel.client_name))
                  result = result.Where(plcy =>  plcy.client_name.Contains(policySearchModel.client_name,StringComparison.InvariantCultureIgnoreCase));
              if(!string.IsNullOrEmpty(policySearchModel.policy_number))
                result = result.Where(plcy =>  plcy.policy_number.Contains(policySearchModel.policy_number,StringComparison.InvariantCultureIgnoreCase));
              if(!string.IsNullOrEmpty(policySearchModel.status))
                result = result.Where(plcy =>  string.Equals(policySearchModel.status, plcy.status, StringComparison.InvariantCultureIgnoreCase));
                if(!string.IsNullOrEmpty(policySearchModel.agent_id))
                result = result.Where(plcy => string.Equals(policySearchModel.agent_id, plcy.agent_id, StringComparison.InvariantCultureIgnoreCase) );
              if(policySearchModel.timeperiod != null || policySearchModel.timeperiod > 0)
                result = result.Where(plcy => plcy.policy_effective_date_datetime.Date>= DateTime.Now.AddMonths(policySearchModel.timeperiod.Value* -1).Date
                                              && plcy.policy_effective_date_datetime.Date <= DateTime.Now.Date );
              if(policySearchModel.is_recent == true)
                  result = result?.OrderByDescending(plcy => plcy.policy_effective_date_datetime.Date )
                  .Take(5);
               return result;
        }
        
    }
}