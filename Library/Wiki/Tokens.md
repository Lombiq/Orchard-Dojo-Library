# Tokens



# In Orchard 1.x



Tokens are pieces of codified text that are be dynamically substituted with other values. E.g. if you want to create a template for an e-mail that should be sent to users but you want to greet the users by their name you can use tokens to send a personalized text like this: "Dear {User.Name}!"

More information about tokens is [in the documentation](http://docs.orchardproject.net/Documentation/Builtin-features#OrchardTokens%28WebPIoffbydefault%29).



# In Orchard Core



In Orchard Core you can use tokens anywhere in that part that supports the usage of tokens. Orchard Core uses the .NET implementation of [Handlebars javascript library](http://handlebarsjs.com/), called [Handlebars.NET](https://github.com/rexm/Handlebars.Net), therefore it's introduce a new syntax for tokens, that means you have to use *{{token_name}}* to signal Orchard that this will be the value of the token named *token_name*. The *token_name* in between the brackets called helper in handlebars.

The 2 braces around the helpers means that it will be HTML encoded, so for URLs if you do not want Handlebars to escape a value, use the "triple-stash" "{{{token_name}}}".

There are 3 helpers in Orchard Core, which are:

- *dateformat*, which is returning the current date in a given format, for instance {{dateformat "yyyy/MM/dd"}}
- *slug*, which is replacing spaces by dashes and lowering the letters of the DisplayText property of the ContentItemMetaData.
- *content* is returning the current content item and with the help of this helper, you can access anything from the content item. For instance you can access the `ContentItemID` by entering the {{content.ContentItemId}} or the Title of the TitlePart by using {{content.Content.TitlePart.Title}}

You can also use tokens in the BodyPart by setting the RenderTokens property to true.