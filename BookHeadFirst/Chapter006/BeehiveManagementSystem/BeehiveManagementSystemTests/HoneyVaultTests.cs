using BeehiveManagementSystem.Models;

namespace BeehiveManagementSystemTests;

public class HoneyVaultTests {
    [Fact]
    private void CollectNectarTest() {
        // Act
        HoneyVault.CollectNectar(10f);

        // Assert
        Assert.Equal(110f, HoneyVault.Nectar);

        // Act
        HoneyVault.CollectNectar(-50f);

        // Assert
        Assert.Equal(110f, HoneyVault.Nectar);
    }

    [Fact]
    private void ConvertNectarToHoneyTest() {
        // Act
        HoneyVault.ConvertNectarToHoney(20f);

        // Assert
        Assert.Equal(28.8f, HoneyVault.Honey);
        Assert.Equal(80f, HoneyVault.Nectar);

        // Act
        HoneyVault.ConvertNectarToHoney(80f);

        // Assert
        Assert.Equal(44f, HoneyVault.Honey);
        Assert.Equal(0f, HoneyVault.Nectar);
    }

    [Fact]
    private void ConsumeHoneyTest() {
        // Assert
        Assert.True(HoneyVault.ConsumeHoney(15f));
        Assert.Equal(10f, HoneyVault.Honey);

        Assert.False(HoneyVault.ConsumeHoney(50f));
        Assert.Equal(10f, HoneyVault.Honey);
    }

    [Fact]
    private void StatusReportTest() {
        // Arrange
        string result = """
                        Vault report:
                        25.0 units of honey
                        100.0 units of nectar
                        """;

        // Assert
        Assert.Equal(result, HoneyVault.StatusReport);

        // Arrange
        result = """
                 Vault report:
                 0.0 units of honey
                 0.0 units of nectar
                 LOW HONEY - ADD A HONEY MANUFACTURER
                 LOW NECTAR - ADD A NECTAR COLLECTOR
                 """;

        // Act
        HoneyVault.ConvertNectarToHoney(100f);
        HoneyVault.ConsumeHoney(44f);

        // Assert
        Assert.Equal(result, HoneyVault.StatusReport);
    }
}