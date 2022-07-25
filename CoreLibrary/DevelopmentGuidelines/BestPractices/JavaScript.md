# JavaScript best practices

Prefix jQuery objects with the dollar sign ($) so they can be distinguished from other objects.

    var $header = $("#header");

----------

Instead of using the $ variable directly use a wrapper to inject the jQuery object and only use the dollar sign in the local scope.

    // The dollar sign will be used only inside the anonymous function here.
    (($) => {
        // The variable $ now refers to jQuery.
    })(jQuery);

----------

Add any DOM manipulation code and event handlers inside the `document.ready()` function to make sure the script does not try to find the elements before the DOM has finished loading. This is recommended by the official [jQuery documentation](https://api.jquery.com/ready/).

    // Notice how it's a shorthand for a wrapper for the $ variable (as above) and also a document.ready() at once.
    // Use this if you only want to write a quick document.ready().
    jQuery(($) => {
        $('.elementClass').on('click', () => { // Click event handler.
            alert('I have been clicked.');
        });
    });

----------

Try to avoid adding variables to the global scope. A handy way of exposing globals is to namespace them under jQuery as demonstrated with the following example:

    (($) => {
        $.extend(true, {
            myModule: {
                // Such deep nesting is not always necessary, the method could be on this level directly
                myClass: { // More of a "class" than a real class of course
                    myMethod() {
                        alert('myMethod called!');
                    },
                },
            },
        });

        // You can use the above like this:
        $.myModule.myClass.myMethod();
    })(jQuery);

----------

When you want to access resources under a given URL of the current web application (like fetching data from a web API endpoint) never hard-code the URL into yours scripts. URLs can change and may depend on the environment (a trivial example being the usage of [ApplicationPath](http://msdn.microsoft.com/en-us/library/system.web.httprequest.applicationpath%28v=vs.110%29.aspx) that e.g. could prefix URL's during local development but can be empty in the production environment).

Instead inject such information into your scripts from templates.
