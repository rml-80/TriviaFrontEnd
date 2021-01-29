# TriviaFrontend
Frontend to Trivia application

## Nuget packeges to used / to be installed
  1. Microsoft.AspNetCore.Components.WebAssembly [Link](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebAssembly/5.0.2?_src=template)
  2. Microsoft.AspNetCore.Components.WebAssembly.Authentication [Link](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebAssembly.Authentication/5.0.2?_src=template) Not configured
  3. Microsoft.AspNetCore.Components.WebAssembly.DevServer [Link](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebAssembly.DevServer/5.0.2?_src=template)
  4. Newtonsoft.Json [Link](https://www.nuget.org/packages/Newtonsoft.Json/12.0.3?_src=template)
  
## What does it do?
  
  A simple FrontEnd Application in Blazor. Gets data from [TrivaBackend](https://github.com/rml-80/Triviabackend).

    You can choose how mwny questions you want to do. min = 1, max = 50. From all categories or a single category.
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