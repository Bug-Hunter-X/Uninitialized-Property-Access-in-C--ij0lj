public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod()
    {
        // Now safe to access MyProperty
        int value = MyProperty * 2;
    }

    //Alternative approach using null-conditional operator
    public void MyMethod2()
    {
        int value = MyProperty.HasValue ? MyProperty.Value * 2 : 0; // Handle null case
    }
} 
