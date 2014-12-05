@ECHO OFF

ECHO Packing GNaP.DependencyInjection
nuget pack src\GNaP.DependencyInjection\GNaP.DependencyInjection.csproj -Build -Prop Configuration=Release -Exclude gnap.ico

ECHO Packing GNaP.DependencyInjection.Web
nuget pack src\GNaP.DependencyInjection.Web\GNaP.DependencyInjection.Web.csproj -Build -Prop Configuration=Release -Exclude gnap.ico -IncludeReferencedProjects

ECHO Packing GNaP.Core
nuget pack src\GNaP.Core\GNaP.Core.csproj -Build -Prop Configuration=Release -Exclude gnap.ico -IncludeReferencedProjects
