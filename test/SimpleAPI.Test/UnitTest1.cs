using System;
using Xunit;
using SimpleAPI.Controllers;
 




namespace SimpleAPI.Controllers; 
{   

public class UnitTest1

{
     ValuesController controller = new ValuesController ();
    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.GetType();
        // Assert.Equal("Salih Yapar", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }

    private class ValuesController
    {
        public ValuesController()
        {
        }
    }
}
}