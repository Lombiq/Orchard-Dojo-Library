# Creating a new repository of the full Orchard source for your project

If from [the possible ways of source controlling an Orchard solution](http://english.orchardproject.hu/blog/ways-of-source-controlling-an-orchard-solution) you've chosen to keep the full Orchard source in your project's repository then these are the steps to follow when creating the solution:

1. Copy over the full Orchard source into your repository.
2. Copy Orchard.sln and rename the copy to the name of your application. Having a copy of the solution file will make upgrades more complicated but it will help to distinguish between the different Orchard solutions you may work on.
3. Rename any references to "Orchard.sln" to your own solution file in the Orchard.proj file in the root.
4. If you're using IIS Express to run the app then it's best to change the default Project Url: right click Orchard.Web/Properties/Web. Using a different app path instead of the default "OrchardLocal" is enough to differentiate between different solutions.
5. Depending on your preference for text file line endings (CRLF - Windows style or LF - Linux style) and the source control system to use (Git or Mercurial; if you use something else then no need to do anything) need you to remove some config files: if you want to store files with the LF line ending in your repo then nothing to do. Otherwise if you use Mercurial remove the .hgeol file, if you use Git remove the .gitattributes file.

For doing upgrades see [this other article](UpdatingOrchard.md).
