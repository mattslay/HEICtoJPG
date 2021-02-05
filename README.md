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


If you don't want to specify the source and target dir, you can just use this format, and it will process all the HEIC files in the current DOS directory.:

    HeicConvert.exe /jpg
    
    HeicConvert.exe /jpg /delete


## Requriement 2:
Once you find an HEIC file, you should check if their is already a converted file with .jpg or .png extension, and you can skip over that files as there is no need to process it if it already exists.

## Rquirement 3:
Print some message like "Processing Item XXXXXXX.HEIC" so there will be some feedback to the console while the app is running.  Or "Skipped file XXXXX.HEIC becuase it has already been converted."






