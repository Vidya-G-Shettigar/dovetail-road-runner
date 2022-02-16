using System.Linq;
using Agents.VictorInsurance.Business.Quote.Services.Interfaces;
using DomainModel = Agents.VictorInsurance.Business.Quote.Infrastructure.Models;
using System.Collections.Generic;
using AutoMapper;
using System;

namespace Agents.VictorInsurance.Business.Quote.Services.Services
{
    public class QuoteService :IQuoteService
    {
        private readonly IMapper _mapper;
        public QuoteService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    
        public static List<DomainModel.Quote> quotes = new List<DomainModel.Quote>
{
        new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC003",proposal_name="Reg_BOP_TC003", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400124ae", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium=112, status = "In Progress", state_code = "THE" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011") , agent_id = "99999999"
        },
        new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC004",proposal_name="Reg_BOP_TC004", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400124ab", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 10225 , status = "In Progress", state_code = "THE" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011") , agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC005",proposal_name="Reg_BOP_TC005", business_line = "Workers Compensation",proposal_number = "618907aef5220149400124ac", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 4995 , status = "Awaiting Bind", state_code = "TX" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011") , agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC006",proposal_name="Reg_BOP_TC006", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400124ad", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 20115 , status = "Declined", state_code = "AR" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC007",proposal_name="Reg_BOP_TC007", business_line = "Workers Compensation",proposal_number = "618907aef5220149400123ae", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium=3000 , status = "In Eligible", state_code = "AZ" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC008",proposal_name="Reg_BOP_TC008", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400124af", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 1140, status = "In Progress", state_code = "THE" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
        new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC009",proposal_name="Reg_BOP_TC009", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400125ab", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 10225 , status = "In Progress", state_code = "THE" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC010",proposal_name="Reg_BOP_TC010", business_line = "Workers Compensation",proposal_number = "618907aef5220149400126ac", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 4995 , status = "Awaiting Bind", state_code = "TX" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC011",proposal_name="Reg_BOP_TC011", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400224ad", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 20115 , status = "Declined", state_code = "AR" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC012",proposal_name="Reg_BOP_TC012", business_line = "Workers Compensation",proposal_number = "618907aef5220149400124ae", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium=3000 , status = "In Eligible", state_code = "AZ" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC013",proposal_name="Reg_BOP_TC013", business_line = "Business Owners Policy",proposal_number = "618907aef5220149500124af", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 1140, status = "In Progress", state_code = "THE" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
        new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC014",proposal_name="Reg_BOP_TC014", business_line = "Business Owners Policy",proposal_number = "618907aef5220149400115ab", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 10225 , status = "In Progress", state_code = "THE" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC015",proposal_name="Reg_BOP_TC015", business_line = "Workers Compensation",proposal_number = "618907aef5220149400116ac", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 4995 , status = "Awaiting Bind", state_code = "TX" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC016",proposal_name="Reg_BOP_TC016", business_line = "Business Owners Policy",proposal_number = "618907aef4220149400224ad", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium= 20115 , status = "Declined", state_code = "AR" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        },
new DomainModel.Quote()
        {
            client_name = "Reg_BOP_TC017",proposal_name="Reg_BOP_TC017", business_line = "Workers Compensation",proposal_number = "618907aef5220149401134ae", carrier = "AmTrust",created_datetime = Convert.ToDateTime("10/01/2011"),
              created_by = "Test_user",premium=3000 , status = "In Eligible", state_code = "AZ" , quote_effective_datetime = Convert.ToDateTime("10/01/2011"),
              quote_expiration_datetime = Convert.ToDateTime("10/01/2011"), last_updated_on_datetime = Convert.ToDateTime("10/01/2011"), agent_id = "99999999"
        }
    };
             public IEnumerable<DomainModel.Quote> Quotes(DomainModel.QuoteSearchModel quoteSearchModel){
               IEnumerable<DomainModel.Quote> result = quotes;
              if(!string.IsNullOrEmpty(quoteSearchModel.client_name))
                  result = result?.Where(quote =>  quote.client_name.Contains(quoteSearchModel.client_name,StringComparison.InvariantCultureIgnoreCase));
              if(!string.IsNullOrEmpty(quoteSearchModel.proposal_number))
                result = result?.Where(quote =>  quote.proposal_number.Contains(quoteSearchModel.proposal_number,StringComparison.InvariantCultureIgnoreCase));
              if(!string.IsNullOrEmpty(quoteSearchModel.status))
                result = result?.Where(quote =>  string.Equals(quoteSearchModel.status, quote.status, StringComparison.InvariantCultureIgnoreCase));
              if(quoteSearchModel.timeperiod != null || quoteSearchModel.timeperiod > 0)
                result = result?.Where(quote => quote.quote_effective_datetime.Date>= DateTime.Now.AddMonths(quoteSearchModel.timeperiod.Value* -1).Date
                                              && quote.quote_effective_datetime.Date <= DateTime.Now.Date );
              if(!string.IsNullOrEmpty(quoteSearchModel.agent_id))
                result = result?.Where(quote =>  string.Equals(quoteSearchModel.agent_id, quote.agent_id, StringComparison.InvariantCultureIgnoreCase));
              
              if(quoteSearchModel.is_recent == true)
               result = result?.Where(quote => quote.quote_effective_datetime.Date != null) 
                              .OrderByDescending(quote => quote.quote_effective_datetime.Date )
                              .Take(5);
              return result;
        }
    }
}