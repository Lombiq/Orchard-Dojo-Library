# Coding best practices



## General Principles to Keep in Mind

- [Don't Repeat Yourself](http://en.wikipedia.org/wiki/Don%27t_repeat_yourself)
- [Loose coupling](http://en.wikipedia.org/wiki/Loose_coupling)
- [Composition over inheritance](http://en.wikipedia.org/wiki/Composition_over_inheritance)
- [Single responsibility principle](http://en.wikipedia.org/wiki/Single_responsibility_principle) and [separation of concerns](http://en.wikipedia.org/wiki/Separation_of_concerns)


## C\# 

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
(String/QueryHints.Empty)


## Orchard

Always do part shape-related heavy work in shape factories inside drivers: this way if the shape is not displayed (i.e. not specified in or hidden from Placement.info) no work will be done.

	protected override DriverResult Display(MyPart part, string displayType, dynamic shapeHelper)
	{
	    return ContentShape("Parts_My",
	        () =>
	        {
	            // This delegate will only run if the shape is actually displayed.
	            var heavy = /* Some heave work */;
	            return shapeHelper.Parts_My(Heavy: heavy);
	        });
	}

----------

If a template uses a static resource (stylesheet or script) always include/require it there even if the template is part of a bigger layout where those resources are already referenced. This makes it easier to keep track of dependent resources and is not prone to errors caused by changes outside the specific template.

----------

For improving client-side performance by preventing blocking script loads always include scripts in the foot if they’re not required immediately on page load. Also consider using the async attribute on scripts (by setting it with SetAttribute() at the time of inclusion) if the order in which they’re executed is indifferent.

	@{
	    // This script will be downloaded asynchronously, without blocking the page loading, but you can't count on it being available at any point in other scripts (so if you have dependent scripts you have to use callbacks or events to signal if the script is loaded).
	    Script.Include("my-async-script").SetAttribute("async", "async");
	
	    // This script will be downloaded synchronously but since it's in the foot it won't block the page load and the user will be able to see the full page sooner.
	    Script.Include("my-script.js").AtFoot();
	
	    // Use such usings to run script blocks depending on foot scripts
	    using (Script.Foot())
	    {
	        <script type="text/javascript">
	            // Use footscripts here
	        </script>
	    }
	}


## JavaScript

Prefix jQuery objects with the dollar sign ($) so they can be distinguished from other objects.

    var $header = $("#header");

## Source control

The following advices apply to the Mercurial source control system and assume the usage of the TortoiseHg client. See the [Mercurial Kick Start](http://mercurial.aragost.com/kick-start/en/) for a more holistic tutorial.

- Try to only include changes corresponding to a single task in a commit.
- Use descriptive commit messages. If a commit corresponds to an issue tracker ticket start the message with the ticket number.
- When you rename a file tell Mercurial that you’ve renamed the file (you can use, there’s not a removed and an added one. This makes possible to maintain file history. You can also [let TortoiseHg automatically detect renames](http://tortoisehg.bitbucket.org/manual/2.0/guess.html).
- If you use branches for developing features prefix the branch names with something and use a pattern like "features/[branch name]" to make those branches distinguishable from other branches.
- Try to avoid merging branches with themselves. If you committed to a branch locally but meanwhile somebody else did the same first, after pulling do the following: instead of merging the two changesets rebase your changeset on top of the remote head. (See the [TortoiseHg Workbench documentation](http://tortoisehg.bitbucket.org/manual/2.0/workbench.html).)
- If you use an issue tracker then have issues open for every task. Then, having issues created, prefix commit messages with the issue ID, e.g. "#11: Fixing title". If you don't use an issue tracker or commit something not related to an issue but your code base is large and consists of multiple distinct sections then prefix your messages with the section name, e.g. "Media Management: Fixed image upload".