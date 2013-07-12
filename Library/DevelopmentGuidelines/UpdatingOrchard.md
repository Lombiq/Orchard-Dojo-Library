# Updating your Orchard instance by copying the latest source


This list serves as a guideline how to update your Orchard source if you maintain a copy of the full source ([see a description for this](http://english.orchardproject.hu/blog/ways-of-source-controlling-an-orchard-solution)).

1. Clone or pull the latest source from the main Orchard repository and update to the changeset you want to update your instance to.
2. Archive a snapshot of the repo at the specific changeset (right click, Export, Archive if you're using TortoiseHg).
3. Remove .hg* files from the archived folder (unless you use the same ones in your own repo).
4. Remove the lib folder in your own solution folder. Outdated libs can cause nasty errors.
5. Copy the source over to your own solution folder.
6. These only apply if you're using a solution file other than the default Orchard.sln (if you're using Orchard.sln just merge that file:
	- Merge Orchard.proj (it references the solution file).
	- Add any new modules to your solution and remove deleted ones (including the removal of the modules' folders).
7. Merge Orchard.Web.csproj. You may have some custom Web.config files like like Web.Release.config included there.
8. Merge Orchard.Web/Web.config if you have modified anything in the original Web.config (better to use custom config files for different build targets).
9. Rebuild the solution to check for any build errors.
10. Run the site to test if everything is working as intended.