:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\DocuSign.Admin\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.13.0.1\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\IO.Swagger.dll /recurse:src\IO.Swagger\*.cs /doc:bin\IO.Swagger.xml
