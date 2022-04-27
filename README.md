# AFI

This is my unfinished solution for the technical assessment - the API functions in that customer details can be sent to the Create endpoint and a Cusotmer record is created and the ID returned. It's mainly validation and tests that are not completed (which are important as they were part of the specification).

The database can be set up by running:
`dotnet ef database update`, ensuring that the startup project is WebAPI

With more time I would have:
- fully implemented the email validation tests and corresponding object validation.
- Added logging
- Added more exceptions for errors beyond just validation (e.g. 404 not found)

For this test I tried to go for a 'clean architecture' approach based on some reading and exercises that I have been looking at recently. See the template https://github.com/jasontaylordev/CleanArchitecture

There is also a lack of comments, however I have tried to use meaningful names and in my opinion any comments that I would add would not add much value to such a simple app.
