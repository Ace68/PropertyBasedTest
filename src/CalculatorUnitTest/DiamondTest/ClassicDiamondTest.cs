namespace DiamondTest;

public class ClassicDiamondTest
{
    [Fact]
    public void Can_Generate_A_Diamond_With_A()
    {
        var diamond = Diamond.Diamond.Generate('A').ToList();
        Assert.Equal(["A"], diamond);
    }
    
    [Fact]
    public void Can_Generate_A_Diamond_With_B()
    {
        var diamond = Diamond.Diamond.Generate('B').ToList();
        Assert.Equal([" A ", "B B", " A "], diamond);
    }
    
    [Fact]
    public void Can_Generate_A_Diamond_With_C()
    {
        var diamond = Diamond.Diamond.Generate('C').ToList();
        Assert.Equal(["  A  ", " B B ", "C   C", " B B ", "  A  "], diamond);
    }
    
    [Fact]
    public void Can_Generate_A_Diamond_With_D()
    {
        var diamond = Diamond.Diamond.Generate('D').ToList();
        Assert.Equal(["   A   ", "  B B  ", " C   C ", "D     D", " C   C ", "  B B  ", "   A   "], diamond);
    }
    
    [Fact]
    public void Can_Generate_A_Diamond_With_E()
    {
        var diamond = Diamond.Diamond.Generate('E').ToList();
        Assert.Equal(["    A    ", "   B B   ", "  C   C  ", " D     D ", "E       E"," D     D ", "  C   C  ", "   B B   ", "    A    "], diamond);
    }
    
    [Fact]
    public void Can_Generate_A_Diamond_With_F()
    {
        var diamond = Diamond.Diamond.Generate('F').ToList();
        Assert.Equal(["     A     ", "    B B    ", "   C   C   ", "  D     D  ", " E       E ", "F         F", " E       E ", "  D     D  ", "   C   C   ", "    B B    ", "     A     "], diamond);
    }
}