# Versioning

[Content items](ContentItem.md) in Orchard are versioned by default: this means that if you edit a content item and publish the modifications you don't overwrite what was previously published but you create a new version - that will be the published version.

## Versioning illustrated

Let's take a look at Page content items, because Page is a content type that's included in Orchard by default.

- Pages are "draftable". This means that you can create draft, i.e. not published (and thus not visible) versions of it. You can also set this option from the admin UI from the content type editor of Page.
- Pages - among others - include the Title and Body [content part](ContentPart.md). These parts have the capability of being versioned. Not every content part is versionable, it's the developer's decision.

That said let's see what happens:

1. You create a new Page and save it, i.e. click the Save button. You **don't** click Publish now. This means the Page is saved, but only as a draft. Nobody can see it on the frontend. The Page only has a single version that is a _draft_. At the same time this version is the _latest_ version.
2. You now publish the Page (e.g. click Publish now in the editor). This means the Page is now visible on the frontend. The Page only has a single version that is the _published_ one, which is also the _latest_.
3. You now edit the Page and save it. This creates a new version of the Page: one is _published_ (and visible) and one is a _draft_ (not visible). So our Page now has two versions; the draft one is the _latest_ (since it's newer than the published version).
4. You now edit the Page again and save it. Editing a draft won't create a new version: only editing a published version and saving it will create a new version. So our Page still has two versions, one being the draft with the content you just saved and the other one being the published version.
5. You now edit the page and instead of clicking Save you click Publish now. This saves the changes to the draft, then publishes it. This means our item still has two versions, both published (the result would be the same if we would just clicked Publish draft from the admin listings: it would made the draft version published).
6. If you now unpublish the item the _latest published_ item will be pushed back to the draft state. This yields that the first version, the published one will be published and again you'll have the _latest_ version as _draft_.

## Soft deletes

Beware that when you remove content items no record is really deleted as Orchard operates with soft deletes: content items are only marked deleted but remain in the database. Actually what happens is that all version of the content item get unpublished and simultaneously loose their flag of being latest; i.e. in the end no version will be marked as published nor latest, thus the item won't be found when fetching the published version.

However, since the versions are still there, they can be retrieved through the [Content Manager](ContentManager.md).
