# HEICtoJPG

Converter for HEIC files to jpg or png


## Example:

    HeicConvert.exe /source="{source directory}"  /target="{target directory}"  /{jpg|png} {/delete}


Example:

    HeicConvert.exe /source = "C:\MyPath" /target = "D:\SomeOtherFolder\SubFolder" /jpg

    HeicConvert.exe /source = "C:\MyPath" /target = "D:\SomeOtherFolder\SubFolder" /png


And, you can use the command line switch to *delete* the original HEIC once conversion is done and verified:

    HeicConvert.exe /source="C:\MyPath" /target="D:\SomeOtherFolder\SubFolder" /jpg /delete



## Note 1
If you don't want to specify the source and target dir, you can just use this format, and it will process all the HEIC files in the current DOS directory:

    HeicConvert.exe /jpg
    
    HeicConvert.exe /jpg /delete

## Note 2
Once the app finds an HEIC file in the source location, it checks if their is already a converted file with the requested .jpg or .png extension, and will skip over converting this file, as there is no need to process it if it already exists.

## Note 3
The app displays a console message like "Processing Item XXXXXXX.HEIC" so there will be some feedback to the console while the app is processsing files.  Or a message like "Skipped file XXXXX.HEIC becuase it has already been converted." if they file has already converted before.

## Note 4
User can specify a /target flag without specifying a /source flag. In this case, all procesing is done on HEIC files found current DOS directory and the location of the converted files will be as the user specified in the /target flag. Example

    HeicConvert.exe /target="D:\SomeOtherFolder\SubFolder" /jpg /delete


# Possbile Future Updates:
 1. We could add a "/force" flag to force a re-writing of the target file if it already exists.
 2. Add a log output file of what processing was done (i.e. note the date and time, /source and /target locations, and each specific file that was converter. Note if /delete flag was used.
 3. Allow input types other than HEIC as the initial file type to convert.
 


