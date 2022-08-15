# TaxSystem
Steps to creating this automation framework
Downloaded and installed visual studio:  https://visualstudio.microsoft.com/downloads/
 Integrated specflow extension
The two steps above are done for every instance of visual studio download
Click on modify on the pop-up after integration of the extension and restart
Open visual studio and select create a project
Select template e.g. “MSTest template”
Created project name  and Solution e.g.  “TaxSystems” 
Selected .Net Core 3.1 (Long-term support)
Download and install the following Nugget Packages on the project :
Speflow- for biding
Specflow Nunit
Specflow.tools.msbuild.generation
Selenium webdriver
Selenium support
SeleniumEwebdriverchromedriver
 NUnit 
Nunit3TestAdapter

Created Feature folders
Features-user journey using Given, When Then
Stepdefinitions-binding to the feature steps
PageObjects-element repository
Hooks- for the selenium webdriver
Utililty-for wait class etc()
Create the hooks class for the webdriver
Create feature files using Gherkins
Generate stepdefinition using specflow
Create element repository that will go into the pageobjects


To run this test
Clean and build codes
Go to test explorer and click on run
