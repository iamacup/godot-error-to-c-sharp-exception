## What?

A simple extension with a bunch of added exceptions to enable the `Error` class to *'throw'*

## How?

 1. Add the GodotExceptions.cs file to your project
 2. Whenever you run a method that returns an error, you can call .ToException() which will throw for any returned error condition

## Example

```
try
{
    file.Open("user://this-file-does-not-exist.dat", File.ModeFlags.Read).ToException();
}
catch(GodotFileNotFoundException)
{
    GD.Print("File did not exist!");
}
```

## List of exceptions

```
throw new GodotFailedException();
throw new GodotUnavailableException();
throw new GodotUnconfiguredException();
throw new GodotUnauthorizedException();
throw new GodotParameterRangeErrorException();
throw new GodotOutOfMemoryException();
throw new GodotFileNotFoundException();
throw new GodotFileBadDriveException();
throw new GodotFileBadPathException();      
throw new GodotFileNoPermissionException();       
throw new GodotFileAlreadyInUseException();
throw new GodotFileCantOpenException();    
throw new GodotFileCantWriteException();
throw new GodotFileCantReadException();
throw new GodotFileUnrecognizedException();
throw new GodotFileCorruptException();
throw new GodotFileMissingDependenciesException();
throw new GodotFileEofException();
throw new GodotCantOpenException();
throw new GodotCantCreateException();
throw new GodotQueryFailedException();
throw new GodotAlreadyInUseException();
throw new GodotLockedException();
throw new GodotTimeoutException();
throw new GodotCantConnectException();
throw new GodotCantResolveException();
throw new GodotConnectionErrorException();
throw new GodotCantAcquireResourceException();
throw new GodotCantForkException();
throw new GodotInvalidDataException();
throw new GodotInvalidParameterException();
throw new GodotAlreadyExistsException();
throw new GodotDoesNotExistException();
throw new GodotDatabaseCantReadException();
throw new GodotDatabaseCantWriteException();
throw new GodotCompilationFailedException();
throw new GodotMethodNotFoundException();
throw new GodotLinkFailedException();
throw new GodotScriptFailedException();
throw new GodotCyclicLinkException();
throw new GodotInvalidDeclarationException();
throw new GodotDuplicateSymbolException();
throw new GodotParseErrorException();
throw new GodotBusyException();
throw new GodotSkipException();
throw new GodotHelpException();
throw new GodotBugException();
throw new GodotPrinterOnFireException();
```

## Some info about them (from the Error definition)

```
// Summary:
//     Generic error.
Failed = 1,
//
// Summary:
//     Unavailable error.
Unavailable = 2,
//
// Summary:
//     Unconfigured error.
Unconfigured = 3,
//
// Summary:
//     Unauthorized error.
Unauthorized = 4,
//
// Summary:
//     Parameter range error.
ParameterRangeError = 5,
//
// Summary:
//     Out of memory (OOM) error.
OutOfMemory = 6,
//
// Summary:
//     File: Not found error.
FileNotFound = 7,
//
// Summary:
//     File: Bad drive error.
FileBadDrive = 8,
//
// Summary:
//     File: Bad path error.
FileBadPath = 9,
//
// Summary:
//     File: No permission error.
FileNoPermission = 10,
//
// Summary:
//     File: Already in use error.
FileAlreadyInUse = 11,
//
// Summary:
//     File: Can't open error.
FileCantOpen = 12,
//
// Summary:
//     File: Can't write error.
FileCantWrite = 13,
//
// Summary:
//     File: Can't read error.
FileCantRead = 14,
//
// Summary:
//     File: Unrecognized error.
FileUnrecognized = 15,
//
// Summary:
//     File: Corrupt error.
FileCorrupt = 16,
//
// Summary:
//     File: Missing dependencies error.
FileMissingDependencies = 17,
//
// Summary:
//     File: End of file (EOF) error.
FileEof = 18,
//
// Summary:
//     Can't open error.
CantOpen = 19,
//
// Summary:
//     Can't create error.
CantCreate = 20,
//
// Summary:
//     Query failed error.
QueryFailed = 21,
//
// Summary:
//     Already in use error.
AlreadyInUse = 22,
//
// Summary:
//     Locked error.
Locked = 23,
//
// Summary:
//     Timeout error.
Timeout = 24,
//
// Summary:
//     Can't connect error.
CantConnect = 25,
//
// Summary:
//     Can't resolve error.
CantResolve = 26,
//
// Summary:
//     Connection error.
ConnectionError = 27,
//
// Summary:
//     Can't acquire resource error.
CantAcquireResource = 28,
//
// Summary:
//     Can't fork process error.
CantFork = 29,
//
// Summary:
//     Invalid data error.
InvalidData = 30,
//
// Summary:
//     Invalid parameter error.
InvalidParameter = 31,
//
// Summary:
//     Already exists error.
AlreadyExists = 32,
//
// Summary:
//     Does not exist error.
DoesNotExist = 33,
//
// Summary:
//     Database: Read error.
DatabaseCantRead = 34,
//
// Summary:
//     Database: Write error.
DatabaseCantWrite = 35,
//
// Summary:
//     Compilation failed error.
CompilationFailed = 36,
//
// Summary:
//     Method not found error.
MethodNotFound = 37,
//
// Summary:
//     Linking failed error.
LinkFailed = 38,
//
// Summary:
//     Script failed error.
ScriptFailed = 39,
//
// Summary:
//     Cycling link (import cycle) error.
CyclicLink = 40,
//
// Summary:
//     Invalid declaration error.
InvalidDeclaration = 41,
//
// Summary:
//     Duplicate symbol error.
DuplicateSymbol = 42,
//
// Summary:
//     Parse error.
ParseError = 43,
//
// Summary:
//     Busy error.
Busy = 44,
//
// Summary:
//     Skip error.
Skip = 45,
//
// Summary:
//     Help error.
Help = 46,
//
// Summary:
//     Bug error.
Bug = 47,
//
// Summary:
//     Printer on fire error. (This is an easter egg, no engine methods return this
//     error code.)
PrinterOnFire = 48
```