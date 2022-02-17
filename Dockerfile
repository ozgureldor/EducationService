from mcr.microsoft.com/dotnet/aspnet:6.0
copy  out/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "run"]