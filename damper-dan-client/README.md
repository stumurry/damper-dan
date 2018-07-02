# Damper Dan Client

# Create Project from scratch

To scaffold a new project:

```
 dotnet new angular
 npm install
 dotnet restore
```

To run the project:

` dotnet run `

navigate browser to `localhost:5000`

Dotnet core support Just in time compilation, so feel free to make changes to either Angular Client or C# Controllers. 

press `ctr + c` to exit dotnet and return back to the command line.

# Add library

Check out Nuget's Gellery:

https://www.nuget.org/

Once a package is found:

` dotnet add <package>`

Be sure to restore packages before running the application:

` dotnet restore `

You are ready to run the application with new library:

` dotnet run`

Its recommeneded that past this point you may consider Visual Studio Code or Visual Studio Community to open up this project.


# Notes:

https://github.com/PomeloFoundation


```
    dotnet add package MySql.Data.EntityFrameworkCore -v 6.10.2-beta

    dotnet restore

```

Before you can use `dotnet ef`:

`dotnet add package Microsoft.EntityFrameworkCore.Design`




