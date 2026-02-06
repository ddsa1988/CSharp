namespace AppTests;

public class UnitTest1 {
    [Fact]
    public void Test1() {
        // Arrange
        var person = new Person() { Name = "Diego" };

        // Act
        person.Name = "Amanda";

        // Assert
        Assert.Equal("Amanda", person.Name);
    }

    private class Person {
        public required string Name { get; set; }
    }
}