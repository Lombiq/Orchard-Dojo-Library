# Creating a new repository of the full Orchard source for your project



If from [the possible ways of source controlling an Orchard solution](http://english.orchardproject.hu/blog/ways-of-source-controlling-an-orchard-solution) you've chosen to keep the full Orchard source in your project's repository then these are the steps to follow when creating the solution:

1. Copy over the full Orchard source into your repository.
2. Copy Orchard.sln and rename the copy to the name of your application. Having a copy of the solution file will make upgrades more complicated but it will help to distinguish between the different Orchard solutions you may work on.
3. Rename any references to "Orchard.sln" to your own solution file in the Orchard.proj file in the root.
4. If you're using IIS Express to run the app then it's best to change the default Project Url: right click Orchard.Web/Properties/Web. Using a different app path instead of the default "OrchardLocal" is enough to differentiate between different solutions.

For doing upgrades see [this other article](UpdatingOrchard).
