FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY ./LISTests/bin/Release/net5.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "LISTests.dll", "LISTests.dll", "--Tests:test_to_run"]