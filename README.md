# xunit-spec-style
Author: Juan Fonseca, Gorilla Logic 2024.

## Description
Demo to write xunit with spec style (as suggested by Zhimin Zhan), the Calculator example was taken from Goenning et al [3].

# Creation [1, 2]
```
dotnet new nunit
dotnet add package Selenium.WebDriver --version 4.24.0
dotnet add package MSTest.TestFramework --version 3.6.1
```

# Execution
```
dotnet test xunit-spec-style.csproj
```

# References
1. Courtney Zhan. Set up and Run Selenium C# Tests in Visual Studio Code on macOS. Medium, Apr 2, 2023. URL: https://courtneyzhan.medium.com/set-up-and-run-selenium-c-tests-in-visual-studio-code-on-macos-179ee9f4a46e (last consulted on 09/05/2024)
2. Marcus Hammarberg. Writing a Selenium test using .NET core and Visual Studio Code. MarcuSoft blog, Oct 7th 2021. URL: https://www.marcusoft.net/2021/10/setting-up-selenium-web-automation-with-net-core.html (last consulted on 09/05/2024)
3. Goenning et al. How do I write context/specification style unit tests with an MSTest/xUnit framework? StackOverflow. URL: https://stackoverflow.com/a/4679146/13176354 (last consulted on 10/07/2024)
