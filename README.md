# Endava
Endava project is made in C#. It's implement Endava UI and RestFull API tasks.

## Built With
### UI
* C#
* Selenium
* Specflow
* Nunit
* Autofac container
  
### Service
* C#
* HttpClient
* Nunit

## Installation
1. Clone the repo
   ```sh
   git clone https://github.com/hristo831/Endava.git
   ```
2. Install Speckflow extention for Visual Studio
3. Chrome browser version must be greater than 105.05

## Roadmap
The project is divided into 5 separate projects
* Test Configuration
  - A project that reads information from testsettings.json file
* UI Framework
  - Implemented the pages following Page Object Design Pattern with partial classes(Page, Page Asserter, Page Map) 
* UI Tests
  - Implemented UI tests following BDD with Specflow(Feature and Steps files)
  - Endava UI scenarios are under EndavaScenarios feature file.
* Service Framework
  - Implemented http requests and responses following Singleton Design pattern with Lazy
* Service Tests
  - Implemented Endava service tests
