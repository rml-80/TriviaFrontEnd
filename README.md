# TriviaFrontEnd
FrontEnd to Trivia application

Built with Blazor WebAssablly in Visual Studio.
[TrivaBackEnd](https://github.com/rml-80/Triviabackend) must be running in order to this to function.

## How to Run
	Download and extraxt.
	Run TriviaFrontend.sln file
	It will open in Visual Studio
	Nuget packeges will be installed
    If not install below noted packages
    Make sure you have started TrivaBackEnd
    Press F5 to run
  
## Nuget packeges to used / to be installed
  1. Microsoft.AspNetCore.Components.WebAssembly [Link](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebAssembly/5.0.2?_src=template)
  2. Microsoft.AspNetCore.Components.WebAssembly.Authentication [Link](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebAssembly.Authentication/5.0.2?_src=template) Not configured
  3. Microsoft.AspNetCore.Components.WebAssembly.DevServer [Link](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebAssembly.DevServer/5.0.2?_src=template)
  4. Newtonsoft.Json [Link](https://www.nuget.org/packages/Newtonsoft.Json/12.0.3?_src=template)
  
## What does it do?
  
  A simple FrontEnd Application in Blazor WebAssembly. Gets data from [TrivaBackEnd](https://github.com/rml-80/Triviabackend).

    You can choose how many questions you want to do. min = 1, max = 50. From all categories or a single category.
    You answer the questions and check if they correct.
    
    Your answer is stored in a propertiy in the question object.
    
    Displays how many correct answers you have.
    
## Error handling
  
  Checkes httpResponseCode.
  If a error occurs it will display a custom error page.

## Solid Principle
I used Single Responsible Principle (SRP).

## Link
https://github.com/rml-80/TriviaFrontEnd
