# Orchard Best Practices



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