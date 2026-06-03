using BeehiveManagementSystem.Models;

namespace BeehiveManagementSystemTests;

public class QueenTests {
    [Fact]
    public void CreateQueenTest() {
        // Arrange
        var queen = new Queen();

        // Act 
        const string result = """
                              Vault report:
                              25.0 units of honey
                              100.0 units of nectar

                              Egg count: 0.0
                              Unassigned workers: 0.0
                              1 Nectar Collector bee
                              1 Honey Manufacturer bee
                              1 Egg Care bee
                              TOTAL WORKERS: 3
                              """;

        // Assert
        Assert.Equal(result, queen.StatusReport);
    }
}