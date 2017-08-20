# RazorTestDemo
aspnet Core 2.0.0 Razor demo

basit kütüphanedir. 
powershell ya da bash, cmd ile kullanılır

Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 2.0.0
Add-Migration Initial
Update-Database

dotnet aspnet-codegenerator razorpage -m Moive -dc MoiveContext -udl -outDir Pages\Moives --referenceScriptLibraries

Yardım için
dotnet aspnet-codegenerator razorpage -h
