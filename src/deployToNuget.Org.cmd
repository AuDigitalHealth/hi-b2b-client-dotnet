del *.nupkg

msbuild /p:Configuration=Release

REM Use dotnet for packaging now
REM NuGet.exe pack HI/HI.csproj -Properties Configuration=Release
dotnet pack .\HI\HI.csproj -c Release -o .

forfiles /m *.nupkg /c "cmd /c NuGet.exe push @FILE -Source https://www.nuget.org/api/v2/package"
