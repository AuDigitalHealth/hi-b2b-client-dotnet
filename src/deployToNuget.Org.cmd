del *.nupkg

nuget restore
msbuild 
msbuild HI.sln /p:Configuration=Release

NuGet.exe pack HI/HI.csproj -Properties Configuration=Release

pause

forfiles /m *.nupkg /c "cmd /c NuGet.exe push @FILE -Source https://www.nuget.org/api/v2/package"
