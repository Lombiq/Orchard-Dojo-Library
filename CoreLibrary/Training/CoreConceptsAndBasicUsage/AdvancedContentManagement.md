# Advanced content management



- Search and indexing (see [the official docs](https://docs.orchardcore.net/en/dev/docs/guides/implement-fulltext-search/) for a guide on this)
	- Enabling Lucene; what is an indexing service (eg. Lucene)
	- Enabling a content type for full-text (content type editor)
	- Creating and configuring an index
- Forms, Liquid and Workflows
 	- An overview of Workflows features
 	- Overview of Liquid
	- Using Forms, using ReCaptcha to prevent spam
 	- Demo: creating a workflow that displays a greeting for users upon logon, displaying their name with Liquid ( `Hello {{User.Identity.Name}}!`)
	- Demo: creating a contact form and handling form posts with a workflow. See [the official docs](https://docs.orchardcore.net/en/dev/docs/topics/workflows/) on this.
- Auditing content with Audit Trail

Time requirement: 2h 30m

Dependencies: [Intermediate content management](IntermediateContentManagement)

Parent topic: [Core concepts and basic usage](./)