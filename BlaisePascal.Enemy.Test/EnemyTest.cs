using BlaisePascal.Esempi.Domain;

namespace BlaisePascal.Esempi.Test;

public class EnemyTest
{
    [Fact]
    public void Enemy_ShouldStartAtLevel()
    {

        Enemy enemy = new Enemy("TestEnemy", 1, 0, 100, 100, true, 0);

    }
}
