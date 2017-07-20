# Gibe.NPoco
Adds UnitOfWork pattern support to NPoco

### IUnitOfWorkProvider

```
GetUnitOfWork() : IUnitOfWork
```

### IUnitOfWork

```
Commit() : void
Database : IDatabase
```

Allows you to do multiple database operations in a transaction. Uses IDisposable interface and disposing the object will rollback the transaction unless Commit() is called first.

### Sample usage:

```c#
using(var unitOfWork = _unitOfWorkProvider.GetUnitOfWork()) 
{
    // Do operations with the database like
    unitOfWork.Database.Insert(objectToInsert)

    unitOfWork.Commit();
}
```

### IDatabaseProvider

Returns an NPoco IDatabase object

``` 
GetDatabase(): IDatabase 
```