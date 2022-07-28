# Admin menu

To integrate your module with Admin UI, you need to add navigation items to it to make your features easily accessible to users. For this purpose you have to create a class that implements the `INavigationProvider` interface. If you only have one class of such functionality, the convention is that the file and the class are named AdminMenu and the file is placed in the project root. If you have multiple of these classes, you may want to keep you project root clean and place these in a solution folder called AdminMenu.

The structure of an Admin menu can be the following:

- you can add any number of items to the Admin menu
- these items can have any number of childrens
- these children items can also have children items displayed as tabs (LocalNav)

For more customization, you can define whether an item should point to the same action as its first child item with the LinkToFirstChild function.

For more information please see the [Visual Studio code snippet](../Utilities/VisualStudioSnippets/) related to AdminMenu and a definite guide on how to create one in the [Orchard Training Demo module](https://github.com/Lombiq/Orchard-Training-Demo-Module), which also describes how to add icons to your navigation items.
