# CompanyClaims.API
Simple RESTful api to get company information and relevant claims

To test the solution, run the project and the Swagger output for solution should be rendered.

Data is loaded into an in memory database for the sake of this demo (so will be reset each time the project is run), data can be viewed/edited from within the `SeedDatabase` class.

The output for one of the get claim results can be used for the patch/update request.

Troubleshooting:

- This project is configured to use SSL local certificates, if you find it is not rendering as expected enabled the "Allow invalid certificates for resources loaded from localhost" flag in chrome