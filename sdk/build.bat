:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\DocuSign.Admin\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.8.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharpSigned.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\IO.Swagger.dll /recurse:src\IO.Swagger\*.cs /doc:bin\IO.Swagger.xml
