# CompanyClaims.API
Simple RESTful api to get company information and relevant claims

To test the solution, run the project and the Swagger output for solution should be rendered.

Data is loaded into an in memory database for the sake of this demo (so will be reset each time the project is run), data can be viewed/edited from within the `SeedDatabase` class.

The output for one of the get claim results can be used for the patch/update request.

Troubleshooting:

- This project is configured to use SSL local certificates, if you find it is not rendering as expected enable the "Allow invalid certificates for resources loaded from localhost" flag in chrome

Examples:

- Example JSON request for update claim would be as follows:
  ```{
  "ucr": "ABDFGFIWS126",
  "companyId": 1,
  "claimTypeId": 2,
  "claimDate": "2024-01-27T22:06:22.3275107Z",
  "lossDate": "0001-01-01T00:00:00",
  "assuredName": "TestClaim-Updated",
  "incurredLoss": 0,
  "closed": true,
  "claimAgeInDays": 150
  }
