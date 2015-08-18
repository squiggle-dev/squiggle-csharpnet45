SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
%CSCPATH%\csc /reference:lib/Newtonsoft.Json.dll;lib/RestSharp.dll /target:library /out:bin/Squiggle.Api.dll /recurse:src\*.cs /doc:bin/Squiggle.Api.xml

