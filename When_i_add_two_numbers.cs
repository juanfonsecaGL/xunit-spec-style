using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xunit_spec_style;

public class When_i_add_two_numbers : With_calculator
{
    public override void When()
    {
        this.Calc.Add(2, 4);
    }

    [TestMethod]
    public void ThenItShouldDisplay6()
    {
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(6, this.Calc.Result);
    }

    [TestMethod]
    public void ThenTheCalculatorShouldNotBeNull()
    {
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(this.Calc);
    }
}