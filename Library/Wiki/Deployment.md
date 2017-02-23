# Deployment



# In Orchard Core


To do an export, you create a Deployment Plan. The Deployment Plan is a set of Deployment Steps. Instead of having to check everything you want everytime you go to the export page, now you can save the state of what you want to export.

You can create custom Deployment Steps, Orchard Core has 3 default Deployment Steps:

- *Content Types*: Exports all the content items for some given content types.
- *Custom File*: Exports a custom file and its content.
- *All Content*: Exports all the content items of the system.

With the help of Orchard.Deployment.Remote module you can create and manage your clients and instances, and send your deployment plans to a remote machine. The Remote Instances can help you to define for instance your staging and production environment. A Remote Client is for security to define a client name and an API key, which you can use to authenticate to the Remote Instance.

To export the Deployment Plan, hit the 'Execute' button to select from the deployment targets. With the help of Deployment targets you can set that where do you want to send the deployment to. If you choose the target called 'File Download' you get your file which is named after the deployment plan. It will be a zip file which contanins the Recipe.json which has the recipe. If you defined custom Remote Instances, you can select them here. Then its executing the deployment plan by harvesting all the data from the different steps. Generating the zip file and (if you choose your custom Remote Instance), sending the zip file to the endpoint of your Remote Instance. Its validating the credentials which was sent with the request and then executing the recipe as a zip file on the Remote Instance.