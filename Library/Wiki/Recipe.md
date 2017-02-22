# Recipe



# In Orchard Core



In Orchard Core the format of the recipe file is JSON instad of XML. A recipe file contains website configuration information. There are three types of recipes:

- Blog.Recipe, that provides a functional Blog with CMS features.
- Cms.Recipe, that provides a function set of CMS features.
- Saas.Recipe, that doesn't enable any content management modules and every enabled module here has no dependency on the content management modules.

Orchard Core introduces a lot of new features when you work with recipe files.

Now you can define the HomeRoute property in the recipe steps, which tells Orchard what will be the homepage of the site.

    {
        "name": "settings",
        "HomeRoute": {
            "Action": "Index",
            "Controller": "Home",
            "Area": "Orchard.Commons"
        }
    }

In this example you can see that the Index action method of the Home controller in the Orchard.Commons module will be the homepage of the site. After the setup has been finished, Orchard will redirect you to the homepage.

Recipes now support variables. The variables are evaluated the first time they are accessed, and reused across steps. Under the `variables` there is a set of variables that are designed for the whole recipe. In this case you can define any variable here, where if you would like to set the value of that variable by a script interpretation, you have to begin it with square bracket. Then you have to define the prefix of the script, that will decide the language of the script.

    {
        "variables": {
            "blogContentItemId": "[js:uuid()]"
        },
    }

Orchard Core support scripts written in JavaScript. You can find the implementation of this scripting engine in the `JavaScriptEngine` class of the `Orchard.Scripting.JavaScript` module. Then you can use the defined variables in the following way:

    {
        "name": "settings",
        "HomeRoute": {
            "Action": "Display",
            "Controller": "Item",
            "Area": "Orchard.Contents",
            "ContentItemId": "[js: variables('blogContentItemId')]"
        },
    }

You can also use parameters in the recipe as you can see in the the following segment: 

    {
          "ContentType": "Blog",
          "ContentItemId": "[js: variables('blogContentItemId')]",
          "Owner": "[js: parameters('AdminUsername')]",
          "Author": "[js: parameters('AdminUsername')]",
    }

The Owner and the Author properties are set by the parameters name AdminUsername. When you execute a recipe you can pass an object containg properties that has been gathered from the UI.

For more information about scripting read the following [README.md file](https://github.com/OrchardCMS/Orchard2/blob/master/src/Orchard.Cms.Web/Modules/Orchard.Scripting/README.md "README.md file") in the Orchard Core repository.