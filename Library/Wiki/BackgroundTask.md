# Background task



The `IBackgroundTask` interface is one of the most simple interfaces you can find in Orchard (aside from the empty marker ones). The only method contained in this interface you need to implement in your class is the Sweep method (without input parameters). Orchard will execute the Sweep method of every IBackgroundTask implementation every 1 minute, so it enables you to simply define some logic that will run periodically. It is useful for recurring tasks and running huge tasks in smaller batches (just like the Orchard.Indexing module does with updating the indices).

For more information please see the [Visual Studio code snippet](../Utilities/VisualStudioSnippets/) related to background tasks and a definite guide on how to create one in the [Orchard Training Demo module](https://orchardtrainingdemo.codeplex.com/).