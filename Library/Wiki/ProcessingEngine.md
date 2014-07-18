# Orchard's Processing Engine



The Processing Engine (what you can use through the injectable dependency `IProcessingEngine`) in Orchard is a service that you can use to run arbitrary code in the context of an HTTP request, but after the request is processed.

Tasks queued in the Processing Engine are synchronously executed after the ambient transaction of the request ends, from `DefaultOrchardHost.EndRequest()`. This means that such tasks can be potentially longer-running as they don't endanger causing a timeout for the request transaction, since they are each run in their own transactions. Processing Engine tasks are still part of the HTTP request though, that means that the execution time of these tasks add to the user-perceivable response time of the application.

Note that since Processing Engine tasks are run after a request naturally they need a request to get executed, on an idle site such tasks won't be processed. Also such tasks are only retained for the scope of the request: if something fatal happens and the request completely fails before tasks can be executed than those tasks will be lost; and tasks queued from background tasks won't be processed at all (since there is no corresponding request).

An example of how the Processing Engine is used is in the built-in Orchard.Comments [module](Module) in `CommentService`: calculating the number of comments under a given content item is being done from a Processing Engine task.