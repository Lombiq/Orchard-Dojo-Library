# Code styling



## C\# styling

If there length of the parameter list for a method is too long to read conveniently in terms of line length (due to the 3-argument rule this should rarely happen for methods but constructors with dependency injection) break it into multiple lines parameter by parameter.

    public class MyClass
    {
        public MyClass(
            IDependency1 dependency1,
            IDependency2 dependency2,
            IDependency3 dependency3)
        {
            // ...
        }
    }

----------

Prefix private fields with an underscore (_).

----------

Keep logical blocks of codes separated by multiple line breaks, forming logical “islands”. This makes the code more readable.

    // Notice the double line breaks between fields/properties and the constructor as well as between the constructor, public and private methods.
    // Properties are separated by a blank line from fields.
    public class MyClass
    {
        private string _myField = "field";

        public int MyProperty { get; set; }


        public MyClass()
        {
        }


        public void MyMethod1()
        {
        }

        public void MyMethod2()
        {
        }


        private void MyPrivateMethod()
        {
        }
    }

If you have multiple types (e.g. an interface and a class) defined in the same file, similarly divide them with two line breaks.

----------

Have a standard ordering of members depending on their visibility and whether they're instance- or class-level, etc.

    //  Notice the order: static, private, protected, public, const, constructor, public, protected, private, static, inner classes
    public class MyClass
    {
        // Constants first
        public const string MyConst = "const";
        
        // Static fields
        private static string _myStaticField = "field";

        // Private fields
        private string _myField = "field";

        protected string _myProtected = "field";

        // Properties next
        public int MyProperty { get; set; }


        // Then the constructor(s)
        public MyClass()
        {
        }


        // Public methods
        public void MyMethod()
        {
        }


        // Protected methods
        protected void MyProtected()
        {
        }


        // Private methods
        private void MyPrivateMethod()
        {
        }


        // Static methods
        private static void MyStaticMethod()
        {
        }


        // Inner classes
        public class MyInnerClass
        {
        }
    }

----------

If an expression is short, omit line breaks when applicable to keep the code compact (as long as readability is not hurt), e.g.:

    public class MyClass
    {
        private int _myField;
        public int MyProperty { get { return _myField; } }
    }


## CSS styling

Structure your stylesheet's content logically under titles. Use the following comment formats for different levels of titles:

	/* First-level title
	***************************************************************/
	
	// Second-level title
	// -------------------------
	
	/* Third-level title */

Use line breaks to space out blocks of code.