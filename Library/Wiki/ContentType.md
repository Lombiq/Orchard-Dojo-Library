# Content type



A content type is a blueprint of how [content items](ContentItem) of that type look like: it defines the set of [content parts](ContentPart) that make up the content types.

A content type only consists of content parts, even if it seems that you can directly attach [content fields](ContentField) to a type from the admin UI. When you attach fields from the admin UI in reality an invisible part is created that has the same name as the content type (e.g. a Page part is created for the Page content type) and the fields get attached to that.

Examples of some basic content types: Page or Blog Post (both containing e.g. Title Part and Body Part).