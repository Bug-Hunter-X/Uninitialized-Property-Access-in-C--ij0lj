# Uninitialized Property Access in C#

This example showcases a common error in C# where a property is accessed before it has been assigned a value.  This can result in unexpected behavior or a `NullReferenceException` at runtime.

The `bug.cs` file demonstrates the problematic code, while `bugSolution.cs` offers a solution to handle this issue.

**Key takeaway:** Always ensure properties are properly initialized before being used to avoid runtime errors.