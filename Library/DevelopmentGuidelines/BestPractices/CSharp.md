# C\# Best Practices



Other than saving object references or instantiating other classes never do any work in a class's constructor. When using a [dependency injection container](http://en.wikipedia.org/wiki/Dependency_injection) the injection of a single dependency can result in the instantiation of dozens of other services. So never count on your class not being instantiated for a given operation.

----------

When returning a collection, always return an empty collection if there are no elements, but never null. When accepting a collection as a method argument, however, always check for null.

	IEnumerable<int> MyMethod(IEnumerable<int> collection)
	{
	    // Check for null and handle it somehow
	    if (collection == null) throw new ArgumentNullException("collection");
	
	    if (nothingToReturn) return Enumerable.Empty<int>();
	    else return normally;
	}

Keep interfaces as short as possible so it’s relatively simple to provide alternative implementation for them (even when doing unit testing).

----------

If a method would serve just as a shortcut for multiple method calls on the same interface, use extension methods. Whether or not to use an extension method should be decided on a case-by case basis as future-aware as possible: only use extension methods if the shortcut is (almost) trivial and add the method to the interface if the optimal solution is more likely to depend on the specific implementation.

	// Good example: the shortcut is simple
	public interface IService
	{
	    void Register(int id);
	}
	
	public static class ServiceExtensions
	{
	    void Register(this IService service, DbEntity entity)
	    {
	        service.Register(entity.Id);
	    }
	}

	// Extensions are also useful if you want to provide default arguments for methods and want to do it with overloads
	public interface IService
    {
        IEnumerable<DbEntity> GetItems(int maxCount);
    }

    public static class ServiceExtensions
    {
        IEnumerable<DbEntity> GetItems(this IService service)
        {
			// This extension provides a default value for the GetItems() method call
            service.GetItems(15);
        }
    }


	// Bad example: GetMany() results in many Get() calls. The implementation of GetMany() is something that the implementation of IService is likely to decide on better.
    public interface IService
    {
        object Get(int id);
    }

    public static class ServiceExtensions
    {
        IEnumerable<object> GetMany(this IService service, IEnumerable<int> ids)
        {
            return ids.Select(id => service.Get(id));
        }
    }

For the extension class use the naming convention of [interface name without the leading I]Extensions as above and put them in the same namespace with the interface (so consumers seeing the interface will likely be able to see the extensions without adding another using statement).

----------

Try to keep the maximal number of arguments on a method to 3.

----------
Always return an interface type and return the most generic one making sense for the typical consuming code.

    public interface IService
    {
        // When in doubt, use IEnumerable<> for collections
        IEnumerable<int> GetItems();

        // If you need List's certain features like mutability or the ability to access items by index commonly in the consuming code return an IList<>
        IList<int> GetItemsList();
    }

----------

Use the "empty pattern" where you want to provide a default object.

    public class MyClass
    {
        // Default will return this single instance, initialized with its default constructor
        private static readonly MyClass _default = new MyClass();
        public static MyClass Default { get { return _default; } }
    }

This is used by .NET's String class (String.Empty) and also by Orchard's QueryHints class (QueryHints.Empty).

----------

When checking if an `IEnumerable<T>` is empty always use `enumerable.Any()` instead of `enumerable.Count() == 0`.