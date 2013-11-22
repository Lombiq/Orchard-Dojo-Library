# Shape



Shapes are dynamic view models that are used to construct the data model behind the layout of a page in Orchard. The resulting structure is a tree (the tree of shapes) where each shape corresponds to a piece of markup in the end: shapes containing other shapes produce wrappers around other pieces of markup while the leaves of this tree  correspond to simple templates. Each shape contains every information to render their corresponding template: they're the view models for their templates.

Some resources:

- [Documentation on shapes](http://docs.orchardproject.net/Documentation/Accessing-and-rendering-shapes)
- [Video tutorial on creating ad-hoc shapes](http://www.youtube.com/watch?v=WXzFH6d0Sbo)
- [Documentation on the usage of Shape Tracing](http://docs.orchardproject.net/Documentation/Customizing-Orchard-using-Designer-Helper-Tools), the tool for determining which shape is behind what you see
- [Documentation on alternates](http://docs.orchardproject.net/Documentation/Alternates): shapes can have have different renderings corresponding to them depending on various factors; those different renderings are called alternates
- [Documentation on Placement.info](http://docs.orchardproject.net/Documentation/Understanding-placement-info) explaining how shapes building up content items' displays and editors are ordered
- [Explaining how shapes are produced in the background](http://fizzylogic.nl/2012/09/05/orchard-advanced-topics-insiders-look-at-shapes-and-templates/)
- [Using shapes as Html helpers](http://www.szmyd.com.pl/blog/using-shapes-as-html-helpers-in-orchard#.UbD1oJzrj-U)
- [Hooking into shape events](http://www.szmyd.com.pl/blog/customizing-orchard-shapes#.UbD1x5zrj-U)