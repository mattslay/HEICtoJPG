# HEICtoJPG

Converter for HEIC files to jpg or png

ToDo: Update app to this command line format and features:

    HeicConvert.exe /source = "{source diretory}"  /target = "{target directory}"  /{jpg|png} {/delete}


Example:

    HeicConvert.exe "C:\MyPath" "D:\SomeOtherFolder\SubFolder\" /jpg

    HeicConvert.exe "C:\MyPath" "D:\SomeOtherFolder\SubFolder\" /png


And, you ccan use the command line switch to *delete* the original HEIC once conversion is done and verified:

    HeicConvert.exe "C:\MyPath" "D:\SomeOtherFolder\SubFolder\" /jpg /delete


If you don't want to specify the source and target dir, you can just use this:

    HeicConvert.exe /jpg
    
    HeicConvert.exe /jpg /delete




