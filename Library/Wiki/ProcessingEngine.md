# Orchard's Processing Engine



The Processing Engine (what you can use through the injectable dependency `IProcessingEngine`) in Orchard is a service that you can use to run arbitrary code in the context of an HTTP request, but after the request is processed.

Tasks queued in the Processing Engine are synchronously executed after the ambient transaction of the request ends, from `DefaultOrchardHost.EndRequest()`. This means that such tasks can be potentially longer-running as they don't endanger causing a timeout for the request transaction, since they are each run in their own transactions. Processing Engine tasks are still part of the HTTP request though, that means that the execution time of these tasks add to the user-perceivable response time of the application.

An example of how the Processing Engine is used is in the built-in Orchard.Comments [module](Module) in `CommentService`: calculating the number of comments under a given content item is being done from a Processing Engine task.