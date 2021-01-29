# Regions-Web-App

A web application (ASP.NET MVC) that displays the information of regions and countries.

## Setup process

1. Clone the project source code from [GitHub](https://github.com/kylerlee/Regions-Web-App.git).
2. Open the project with Visual Studio.
3. Build the project.
4. Run the project in development mode by selecting `Start Without Debugging`.
5. The home page of the web app will be loaded in the default browser.

## Development Note

1. For better readability:-
- The languages/currencies (if more than one) of each country are concatenated into a single line.
- Empty strings are replaced by "Nil".
2. For secured coding practice:-
- Exception thrown when sending request to 3rd party API (country API) is being handled with displaying common error page to prevent excessive information being provided to the users.

## License

The content of this repository is licensed under a [MIT License](https://github.com/kylerlee/Regions-Web-App/blob/master/LICENSE).
