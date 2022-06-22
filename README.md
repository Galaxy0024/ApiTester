# ApiTester
Reference project for creating api requests, inheritance, logging using factory design pattern

## API requests
For managing API requests I used the Random data API, found at: https://random-data-api.com. 
The app is sending a GET request to the API, and saves the json result in a prefedined CryptoCurrency object.

## Class hierarchy
While making the class hierarchy, I decided to use an abstract Currency class, which defines the future subclasses, setting uid as a base field.
It includes a virtual and an abstract method.
This will ensure the addition of multiple currency types in the future.

## Logging
Since the client currently only requested logging to the console and to a csv file, there is a high chance, that 
later on there will be a need for database logging as well.
For this reason I decided to use the factory design pattern, while implementing the Logging classes. This way adding a database logging won't cause any
issues, and the code will remain clean.
