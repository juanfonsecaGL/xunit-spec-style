using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace xunit_spec_style;

public class SpecificationContext
{
    [TestInitialize]
    public void Init()
    {
        this.Given();
        this.When();
    }

    public virtual void Given(){}
    public virtual void When(){}
}