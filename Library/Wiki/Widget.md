# Widget



# In Orchard Core



In Orchard Core, widgets not just about layers, it is about any block of HTML you want to render somewhere based on some conditions. Widget is still a `ContentType` and a `ContentItem`. The `Orchard.Widgets` module is just describing templates for widgets to edit and display a widget.

`Orchard.Flows` module is the 'new' `Orchard.Layouts` module in Orchard Core.

You can use javascript in the Rule field of the Layer Editor so have the possibility to write complex conditions that returns boolean, like :

    if (isHomePage() && new Date().getFullYear() > 2018)