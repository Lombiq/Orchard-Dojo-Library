# Background task



# In Orchard 1.x



The `IBackgroundTask` interface is one of the most simple interfaces you can find in Orchard (aside from the empty marker ones). The only method contained in this interface you need to implement in your class is the Sweep method (without input parameters). Orchard will execute the Sweep method of every IBackgroundTask implementation every 1 minute, so it enables you to simply define some logic that will run periodically. It is useful for recurring tasks and running huge tasks in smaller batches (just like the Orchard.Indexing module does with updating the indices).

For more information please see the [Visual Studio code snippet](../Utilities/VisualStudioSnippets/) related to background tasks and a definite guide on how to create one in the [Orchard Training Demo module](https://orchardtrainingdemo.codeplex.com/).



# In Orchard Core



`BackgroundTaskAttribute` is that what you can optionally add to a background task to define a group. A group will define another set of background tasks to be run in the same period, like every 5 minutes all of this tasks from the same group will be executed. So the group could be frequent, unfrequent or very unfrequent depends on the given time period. Of course you can run background tasks independently without the group attribute like in Orchard 1.x, or you can have a custom group, that means these tasks will not blocked by any other one. Inside a group, background tasks are synchronous, the first executes, then the second, etc. in for instance every 5 minutes. To implement one, you just implement the `DoWorkAsync` method in `IBackgroundTask`.

Background tasks must be singleton, because a background task is running all the time the application works. Then it has a constant state share accross all the executions and each executions run in a seperate scope. If it wont be a singleton, it couldnt share state accross instances.  