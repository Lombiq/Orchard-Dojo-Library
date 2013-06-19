# JavaScript best practices



Prefix jQuery objects with the dollar sign ($) so they can be distinguished from other objects.

    var $header = $("#header");

----------

Instead of using the $ variable directly use a wrapper to inject the jQuery object and only use the dollar sign in the local scope.

	// The dollar sign will be used only inside the anonymous function here.
	(function ($) {
		// Notice the shorthand document.ready function.
	    $(function() {
	        alert("Document ready!")
	    });
	})(jQuery);

----------

Try to avoid adding variables to the global scope. A handy way of exposing globals is to namespace them under jQuery as demonstrated with the following example:
	
	(function ($) {
	    $.extend(true, {
	        myModule: {
				// Such deep nesting is not always necessary, the method could be on this level directly
	            myClass: { // More of a "class" than a real class of course
	                myMethod: function () {
						alert("myMethod called!");
	                }
	            }
	        }
	    });

		// You can use the above like this:
		$.myModule.myClass.myMethod();
	})(jQuery);