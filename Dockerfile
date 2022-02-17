from mcr.microsoft.com/dotnet/aspnet:6.0
copy  ./ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "run"]