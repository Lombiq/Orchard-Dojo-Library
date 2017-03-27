# Content part driver



# In Orchard 1.x



[Drivers](http://docs.orchardproject.net/Documentation/Basic-Orchard-Concepts#Driver) (more precisely: content part drivers) are pieces of code used in conjunction with [content parts](ContentPart). They are responsible for building the editor and display as well as handling importing and exporting of a content part.

Note that the same part can have multiple drivers.



# In Orchard Core



Orchard Core removes the notion of Drivers. Drivers are not required to have static binding anymore to a Part or a Field as they can manipulate any part of a content item now. 

In Orchard Core, when you create a driver, you have to derive your DisplayDriver from `ContentDisplayDriver`, that will responsible for building the editor and the display for your class that do not have to be a content part.

You do not need to have a Placement.info file, you can set the DisplayType and Location of the shape when no specific placement applies directly from the Driver.