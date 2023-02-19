using Xunit;
using MyRootLib;

namespace MyRootLibTest;

public class UnitTest1{
    [Fact]
	public void FourTimes5() {
	
		double a = 4;
        double b = 5; // arrange
		double expected = 20;
	
        double actual = Root.MyProduct(a, b); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void SixTimes7() {
    
		double a = 6;
        double b = 7; // arrange
		double expected = 42;
	
		double actual = Root.MyProduct(a, b); // act

		Assert.Equal(expected, actual); // assert
	} 
}