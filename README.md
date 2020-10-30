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