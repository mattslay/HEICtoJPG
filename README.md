# HEICtoJPG

Converter for HEIC files to jpg or png


# ToDo:
## Update app to this command line format and features:

    HeicConvert.exe /source = "{source directory}"  /target = "{target directory}"  /{jpg|png} {/delete}


Example:

    HeicConvert.exe /source = "C:\MyPath" /target = "D:\SomeOtherFolder\SubFolder\" /jpg

    HeicConvert.exe /source = "C:\MyPath" /target = "D:\SomeOtherFolder\SubFolder\" /png


And, you can use the command line switch to *delete* the original HEIC once conversion is done and verified:

    HeicConvert.exe /source ="C:\MyPath" /target="D:\SomeOtherFolder\SubFolder\" /jpg /delete


If you don't want to specify the source and target dir, you can just use this:

    HeicConvert.exe /jpg
    
    HeicConvert.exe /jpg /delete




