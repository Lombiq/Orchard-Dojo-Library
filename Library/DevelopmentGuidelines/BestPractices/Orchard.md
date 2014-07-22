# Orchard best practices



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

When writing a theme if something is achievable by only CSS, then use only CSS and avoid having shape template overrides with minimal modifications. If you absolutely have to create shape overrides then try to override the most specific shape possible: e.g. if you need to override the markup of blogposts' date shown then override just Common.Metadata (the shape responsible for showing the date) and not the whole Content shape.

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

----------

When you have multiple features in a single module always make the sub-features depend on the main feature for clarity. It should also be the requirement anyway: sub-features are in that module because they have something in common with the main feature.

----------

Always set the Build Action of non-code files (like Placement.info) to Content (under the file's properties in Visual Studio) if they are included in the project (and don't have Content set by default, what they mostly have). Otherwise MSBuild will fail when building Orchard. See a [related blogpost](http://english.orchardproject.hu/blog/orchard-brotips-always-set-placement.info-build-action-to-content).

----------

Although not mandatory, it's good practice to route all your admin controller to under /Admin in a similar way how controllers named AdminController are routed by default. This makes it easier to set up rules for the admin area if one needs it.

----------

Texts presented to the user should always be in form of LocalizedStrings (aka T()). When you want to display dynamic data in the string, use the params of T(). See the relevant [documentation](http://docs.orchardproject.net/Documentation/Using-the-localization-helpers).

----------

It's good practice to let subfeatures of a module always depend on the main feature (the one that is named the same as the module). This will prevent confusion if you want to place some common functionality in the main feature.

----------

It's nice to have a consistent ordering for dependencies in module manifest files. A good way is to begin with third-party features, then list built-in ones (Orchard.*), both in alphabetical order.

----------

When writing a recurring scheduled task (i.e scheduled tasks that re-schedule themselves) then add the re-scheduling as early as possible to the task handler's Process() method. This lowers the chance of an error causing the task not to be re-scheduled.

----------

When doing I/O-bound work, always use async APIs if available (e.g. web requests, file writes). Using async I/O greatly increases the throughput of the server by not blocking threads to wait for I/O completion.

----------

When you add a client-side plugin to your module or theme (like a jQuery plugin that uses various JS and CSS files, has a readme, etc.) then it's best to keep the folder structure of the plugin intact and copy it to the extension's Content folder (a folder simply serving static files with the same Web.config as Styles and Scripts folders) under its own subfolder. This way maintaining and upgrading the plugin will be easier, not to mention that developers will be able to see all of its files at once.

You'll be able to still include static resources from such a folder through the ResourceManager, you'll just have to use relative paths, e.g. like this in a [resource manifest](../../Wiki/ResourceManifest):

    manifest.DefineScript("MyScript").SetUrl("~/Themes/MyTheme/Content/Plugin/script.js"...

The same goes for `Script/Style.Include()` calls from view templates.

----------

When writing Migrations it's best to consolidate the latest schema in the Create method and only make UpdateFromX() run for existing installations.

    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable(typeof(PersonRecord).Name,
                table => table
                    .Column<int>("Id", column => column.PrimaryKey().Identity())
                    .Column<string>("Name")
                    // The Bio column was added later, so it's added in UpdateFrom1() for existing installations.
                    // It's also added here for new installations.
                    .Column<string>("Bio", column => column.Unlimited())
                );

            // UpdateFrom1() won't run for new installations, they will have the Bio column added by default.
            return 2;
        }

        public int UpdateFrom1()
        {
            // Adding the Bio column for old installations.
            SchemaBuilder.AlterTable(typeof(PersonRecord).Name,
                table =>
                    table.AddColumn<string>("Bio", column => column.Unlimited())
                );

            return 2;
        }
    }