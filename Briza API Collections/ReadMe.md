Please use the below steps accordingly to execute Api's on Postman

1) Set api_key and the brokerage_id in the collection. 
   
   Note: This remains same for all the collections we use.
   

2) Execute List Underwriters APi and List brokerage credentials Api, This will gives us the list of underwriters. Choose underwriter_id for those who has appetite's. And update the underwriter id in the collection variable.

3) If you are not able to get any appetite's for the underwriters, then you execute "Add credential details to brokerage" Api to add underwriter, who is present in "List Underwriters" Api response but not in "List brokerage credentials" Api response.


4) Execute “Create Pre-application” Api to get Pre_app_id

5) Execute "Answer pre-application" Api with Request parameters.

6) Execute “Create Application” APi to get app_id.

7) Execute "Answer application questions" Api with Request parameters.

8) Execute “Create new quotes” Api to create the quotation and get the quote_id's

7) Execute “Check List quotation by application” to see the list of quotations.

8) Select quote_id based on the status. Pick up the quote_id if its status is "quoted" and update on collection variables. 

9) Execute “Create a Policy” Api to create a policy for the quotation.