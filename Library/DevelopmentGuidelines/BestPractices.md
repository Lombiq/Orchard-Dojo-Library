# Coding best practices



## C\# 

When returning a collection, always return an empty collection if there are no elements, but never null. When accepting a collection as a method argument, however, always check for null.

	IEnumerable<int> MyMethod(IEnumerable<int> collection)
	{
	    // Check for null and handle it somehow
	    if (collection == null) throw new ArgumentNullException("collection");
	
	    if (nothingToReturn) return Enumerable.Empty<int>();
	    else return normally;
	}

Keep interfaces as short as possible so it’s relatively simple to provide alternative implementation for them (even when doing unit testing).

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

- Maximal number of arguments on a method: 3
- Always return an interface type and return the most generic one making sense for the typical consuming code.
- The “empty” pattern (String/QueryHints.Empty)


## Orchard
- Always do part shape-related heavy work in shape factories: this way if the shape is not displayed (i.e. not specified in or hidden from Placement.info) no work will be done.
- If a template uses a static resource (stylesheet or script) always include/require it there even if the template is part of a bigger layout where those resoruces are already referenced.
- For improving client-side performance by preventing blocking script loads always include scripts in the foot if they’re not required immediately on page load. Also consider using the async attribute on scripts (by setting it with SetAttribute() at the time of inclusion) if the order in which they’re executed is indifferent.


## JavaScript:
- Prefix jQuery objects with the dollar sign ($)


## Source control:
- Try to only include changes corresponding to a single task in a commit.
- Use descriptive commit messages. If a commit corresponds to an issue tracker ticket start the message with the ticket number.
- When you rename a file tell the source control system that you’ve renamed the file, there’s not a removed and an added one. This makes possible to maintain file history.