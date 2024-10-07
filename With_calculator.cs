namespace xunit_spec_style;

public class With_calculator : SpecificationContext
{
    protected Calculator Calc;

    public override void Given()
    {
        Calc = new Calculator();
    }
}