using Godot;
using System;

public static class GodotErrorToException
{ 
    public static void ToException(this Error error)
    {
        if(error == Error.Failed)
        {
            throw new GodotFailedException();
        }
        else if(error == Error.Unavailable)
        {
            throw new GodotUnavailableException();
        }
        else if(error == Error.Unconfigured)
        {
            throw new GodotUnconfiguredException();
        }
        else if(error == Error.Unauthorized)
        {
            throw new GodotUnauthorizedException();
        }
        else if(error == Error.ParameterRangeError)
        {
            throw new GodotParameterRangeErrorException();
        }
        else if(error == Error.OutOfMemory)
        {
            throw new GodotOutOfMemoryException();
        }
        else if(error == Error.FileNotFound)
        {
            throw new GodotFileNotFoundException();
        }
        else if(error == Error.FileBadDrive)
        {
            throw new GodotFileBadDriveException();
        }
        else if(error == Error.FileBadPath)
        {
            throw new GodotFileBadPathException();
        }
        else if(error == Error.FileNoPermission)
        {
            throw new GodotFileNoPermissionException();
        }
        else if(error == Error.FileAlreadyInUse)
        {
            throw new GodotFileAlreadyInUseException();
        }
        else if(error == Error.FileCantOpen)
        {
            throw new GodotFileCantOpenException();
        }
        else if(error == Error.FileCantWrite)
        {
            throw new GodotFileCantWriteException();
        }
        else if(error == Error.FileCantRead)
        {
            throw new GodotFileCantReadException();
        }
        else if(error == Error.FileUnrecognized)
        {
            throw new GodotFileUnrecognizedException();
        }
        else if(error == Error.FileCorrupt)
        {
            throw new GodotFileCorruptException();
        }
        else if(error == Error.FileMissingDependencies)
        {
            throw new GodotFileMissingDependenciesException();
        }
        else if(error == Error.FileEof)
        {
            throw new GodotFileEofException();
        }
        else if(error == Error.CantOpen)
        {
            throw new GodotCantOpenException();
        }
        else if(error == Error.CantCreate)
        {
            throw new GodotCantCreateException();
        }
        else if(error == Error.QueryFailed)
        {
            throw new GodotQueryFailedException();
        }
        else if(error == Error.AlreadyInUse)
        {
            throw new GodotAlreadyInUseException();
        }
        else if(error == Error.Locked)
        {
            throw new GodotLockedException();
        }
        else if(error == Error.Timeout)
        {
            throw new GodotTimeoutException();
        }
        else if(error == Error.CantConnect)
        {
            throw new GodotCantConnectException();
        }
        else if(error == Error.CantResolve)
        {
            throw new GodotCantResolveException();
        }
        else if(error == Error.ConnectionError)
        {
            throw new GodotConnectionErrorException();
        }
        else if(error == Error.CantAcquireResource)
        {
            throw new GodotCantAcquireResourceException();
        }
        else if(error == Error.CantFork)
        {
            throw new GodotCantForkException();
        }
        else if(error == Error.InvalidData)
        {
            throw new GodotInvalidDataException();
        }
        else if(error == Error.InvalidParameter)
        {
            throw new GodotInvalidParameterException();
        }
        else if(error == Error.AlreadyExists)
        {
            throw new GodotAlreadyExistsException();
        }
        else if(error == Error.DoesNotExist)
        {
            throw new GodotDoesNotExistException();
        }
        else if(error == Error.DatabaseCantRead)
        {
            throw new GodotDatabaseCantReadException();
        }
        else if(error == Error.DatabaseCantWrite)
        {
            throw new GodotDatabaseCantWriteException();
        }
        else if(error == Error.CompilationFailed)
        {
            throw new GodotCompilationFailedException();
        }
        else if(error == Error.MethodNotFound)
        {
            throw new GodotMethodNotFoundException();
        }
        else if(error == Error.LinkFailed)
        {
            throw new GodotLinkFailedException();
        }
        else if(error == Error.ScriptFailed)
        {
            throw new GodotScriptFailedException();
        }
        else if(error == Error.CyclicLink)
        {
            throw new GodotCyclicLinkException();
        }
        else if(error == Error.InvalidDeclaration)
        {
            throw new GodotInvalidDeclarationException();
        }
        else if(error == Error.DuplicateSymbol)
        {
            throw new GodotDuplicateSymbolException();
        }
        else if(error == Error.ParseError)
        {
            throw new GodotParseErrorException();
        }
        else if(error == Error.Busy)
        {
            throw new GodotBusyException();
        }
        else if(error == Error.Skip)
        {
            throw new GodotSkipException();
        }
        else if(error == Error.Help)
        {
            throw new GodotHelpException();
        }
        else if(error == Error.Bug)
        {
            throw new GodotBugException();
        }
        else if(error == Error.PrinterOnFire)
        {
            throw new GodotPrinterOnFireException();
        }
    }
}
public class GodotOkException : Exception
{
    public GodotOkException()
    {
    }
    public GodotOkException(string message)
        : base(message)
    {
    }
    public GodotOkException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFailedException : Exception
{
    public GodotFailedException()
    {
    }
    public GodotFailedException(string message)
        : base(message)
    {
    }
    public GodotFailedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotUnavailableException : Exception
{
    public GodotUnavailableException()
    {
    }
    public GodotUnavailableException(string message)
        : base(message)
    {
    }
    public GodotUnavailableException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotUnconfiguredException : Exception
{
    public GodotUnconfiguredException()
    {
    }
    public GodotUnconfiguredException(string message)
        : base(message)
    {
    }
    public GodotUnconfiguredException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotUnauthorizedException : Exception
{
    public GodotUnauthorizedException()
    {
    }
    public GodotUnauthorizedException(string message)
        : base(message)
    {
    }
    public GodotUnauthorizedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotParameterRangeErrorException : Exception
{
    public GodotParameterRangeErrorException()
    {
    }
    public GodotParameterRangeErrorException(string message)
        : base(message)
    {
    }
    public GodotParameterRangeErrorException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotOutOfMemoryException : Exception
{
    public GodotOutOfMemoryException()
    {
    }
    public GodotOutOfMemoryException(string message)
        : base(message)
    {
    }
    public GodotOutOfMemoryException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileNotFoundException : Exception
{
    public GodotFileNotFoundException()
    {
    }
    public GodotFileNotFoundException(string message)
        : base(message)
    {
    }
    public GodotFileNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileBadDriveException : Exception
{
    public GodotFileBadDriveException()
    {
    }
    public GodotFileBadDriveException(string message)
        : base(message)
    {
    }
    public GodotFileBadDriveException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileBadPathException : Exception
{
    public GodotFileBadPathException()
    {
    }
    public GodotFileBadPathException(string message)
        : base(message)
    {
    }
    public GodotFileBadPathException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileNoPermissionException : Exception
{
    public GodotFileNoPermissionException()
    {
    }
    public GodotFileNoPermissionException(string message)
        : base(message)
    {
    }
    public GodotFileNoPermissionException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileAlreadyInUseException : Exception
{
    public GodotFileAlreadyInUseException()
    {
    }
    public GodotFileAlreadyInUseException(string message)
        : base(message)
    {
    }
    public GodotFileAlreadyInUseException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileCantOpenException : Exception
{
    public GodotFileCantOpenException()
    {
    }
    public GodotFileCantOpenException(string message)
        : base(message)
    {
    }
    public GodotFileCantOpenException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileCantWriteException : Exception
{
    public GodotFileCantWriteException()
    {
    }
    public GodotFileCantWriteException(string message)
        : base(message)
    {
    }
    public GodotFileCantWriteException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileCantReadException : Exception
{
    public GodotFileCantReadException()
    {
    }
    public GodotFileCantReadException(string message)
        : base(message)
    {
    }
    public GodotFileCantReadException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileUnrecognizedException : Exception
{
    public GodotFileUnrecognizedException()
    {
    }
    public GodotFileUnrecognizedException(string message)
        : base(message)
    {
    }
    public GodotFileUnrecognizedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileCorruptException : Exception
{
    public GodotFileCorruptException()
    {
    }
    public GodotFileCorruptException(string message)
        : base(message)
    {
    }
    public GodotFileCorruptException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileMissingDependenciesException : Exception
{
    public GodotFileMissingDependenciesException()
    {
    }
    public GodotFileMissingDependenciesException(string message)
        : base(message)
    {
    }
    public GodotFileMissingDependenciesException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotFileEofException : Exception
{
    public GodotFileEofException()
    {
    }
    public GodotFileEofException(string message)
        : base(message)
    {
    }
    public GodotFileEofException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCantOpenException : Exception
{
    public GodotCantOpenException()
    {
    }
    public GodotCantOpenException(string message)
        : base(message)
    {
    }
    public GodotCantOpenException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCantCreateException : Exception
{
    public GodotCantCreateException()
    {
    }
    public GodotCantCreateException(string message)
        : base(message)
    {
    }
    public GodotCantCreateException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotQueryFailedException : Exception
{
    public GodotQueryFailedException()
    {
    }
    public GodotQueryFailedException(string message)
        : base(message)
    {
    }
    public GodotQueryFailedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotAlreadyInUseException : Exception
{
    public GodotAlreadyInUseException()
    {
    }
    public GodotAlreadyInUseException(string message)
        : base(message)
    {
    }
    public GodotAlreadyInUseException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotLockedException : Exception
{
    public GodotLockedException()
    {
    }
    public GodotLockedException(string message)
        : base(message)
    {
    }
    public GodotLockedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotTimeoutException : Exception
{
    public GodotTimeoutException()
    {
    }
    public GodotTimeoutException(string message)
        : base(message)
    {
    }
    public GodotTimeoutException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCantConnectException : Exception
{
    public GodotCantConnectException()
    {
    }
    public GodotCantConnectException(string message)
        : base(message)
    {
    }
    public GodotCantConnectException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCantResolveException : Exception
{
    public GodotCantResolveException()
    {
    }
    public GodotCantResolveException(string message)
        : base(message)
    {
    }
    public GodotCantResolveException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotConnectionErrorException : Exception
{
    public GodotConnectionErrorException()
    {
    }
    public GodotConnectionErrorException(string message)
        : base(message)
    {
    }
    public GodotConnectionErrorException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCantAcquireResourceException : Exception
{
    public GodotCantAcquireResourceException()
    {
    }
    public GodotCantAcquireResourceException(string message)
        : base(message)
    {
    }
    public GodotCantAcquireResourceException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCantForkException : Exception
{
    public GodotCantForkException()
    {
    }
    public GodotCantForkException(string message)
        : base(message)
    {
    }
    public GodotCantForkException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotInvalidDataException : Exception
{
    public GodotInvalidDataException()
    {
    }
    public GodotInvalidDataException(string message)
        : base(message)
    {
    }
    public GodotInvalidDataException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotInvalidParameterException : Exception
{
    public GodotInvalidParameterException()
    {
    }
    public GodotInvalidParameterException(string message)
        : base(message)
    {
    }
    public GodotInvalidParameterException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotAlreadyExistsException : Exception
{
    public GodotAlreadyExistsException()
    {
    }
    public GodotAlreadyExistsException(string message)
        : base(message)
    {
    }
    public GodotAlreadyExistsException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotDoesNotExistException : Exception
{
    public GodotDoesNotExistException()
    {
    }
    public GodotDoesNotExistException(string message)
        : base(message)
    {
    }
    public GodotDoesNotExistException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotDatabaseCantReadException : Exception
{
    public GodotDatabaseCantReadException()
    {
    }
    public GodotDatabaseCantReadException(string message)
        : base(message)
    {
    }
    public GodotDatabaseCantReadException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotDatabaseCantWriteException : Exception
{
    public GodotDatabaseCantWriteException()
    {
    }
    public GodotDatabaseCantWriteException(string message)
        : base(message)
    {
    }
    public GodotDatabaseCantWriteException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCompilationFailedException : Exception
{
    public GodotCompilationFailedException()
    {
    }
    public GodotCompilationFailedException(string message)
        : base(message)
    {
    }
    public GodotCompilationFailedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotMethodNotFoundException : Exception
{
    public GodotMethodNotFoundException()
    {
    }
    public GodotMethodNotFoundException(string message)
        : base(message)
    {
    }
    public GodotMethodNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotLinkFailedException : Exception
{
    public GodotLinkFailedException()
    {
    }
    public GodotLinkFailedException(string message)
        : base(message)
    {
    }
    public GodotLinkFailedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotScriptFailedException : Exception
{
    public GodotScriptFailedException()
    {
    }
    public GodotScriptFailedException(string message)
        : base(message)
    {
    }
    public GodotScriptFailedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotCyclicLinkException : Exception
{
    public GodotCyclicLinkException()
    {
    }
    public GodotCyclicLinkException(string message)
        : base(message)
    {
    }
    public GodotCyclicLinkException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotInvalidDeclarationException : Exception
{
    public GodotInvalidDeclarationException()
    {
    }
    public GodotInvalidDeclarationException(string message)
        : base(message)
    {
    }
    public GodotInvalidDeclarationException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotDuplicateSymbolException : Exception
{
    public GodotDuplicateSymbolException()
    {
    }
    public GodotDuplicateSymbolException(string message)
        : base(message)
    {
    }
    public GodotDuplicateSymbolException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotParseErrorException : Exception
{
    public GodotParseErrorException()
    {
    }
    public GodotParseErrorException(string message)
        : base(message)
    {
    }
    public GodotParseErrorException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotBusyException : Exception
{
    public GodotBusyException()
    {
    }
    public GodotBusyException(string message)
        : base(message)
    {
    }
    public GodotBusyException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotSkipException : Exception
{
    public GodotSkipException()
    {
    }
    public GodotSkipException(string message)
        : base(message)
    {
    }
    public GodotSkipException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotHelpException : Exception
{
    public GodotHelpException()
    {
    }
    public GodotHelpException(string message)
        : base(message)
    {
    }
    public GodotHelpException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotBugException : Exception
{
    public GodotBugException()
    {
    }
    public GodotBugException(string message)
        : base(message)
    {
    }
    public GodotBugException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class GodotPrinterOnFireException : Exception
{
    public GodotPrinterOnFireException()
    {
    }
    public GodotPrinterOnFireException(string message)
        : base(message)
    {
    }
    public GodotPrinterOnFireException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
