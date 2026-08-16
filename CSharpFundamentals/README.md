\# Book Pro CSharp 10 With Net.6 - Page 78



dotnet --version => Display the .NET SDK version in use



dotnet --info => Display .NET information



dotnet --list--runtimes => Display the installed runtimes



dotnet --list-sdks => Display the installed SDKs



dotnet sdk check => Check for updates



dotnet new globaljson -sdk-version 10.0.102 -o "Directory Name" =>  Specifies the version of .NET that the project will use



dotnet new sln -n "Solution Name" -o "Directory Name" => Create a new solution with the name (-n) in a subdirectory of the current directory (-o)



dotnet new console -lang c# -n "Project Name" -o "Directory Name" -f net10.0 => Create a new console app in c# (-lang) with the dotnet framework 10.0 (-f)



dotnet sln "Solution path" add "Project path" => Add a Project to the solution



dotnet restore => Restore all of the NuGet packages required for the solution and Project



dotnet build => Restore and build all of the projects in the solution



dotnet run => Run the Project without debuging

