using UnityEngine;

public class EnemyFacrica : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public Enemy CreateMeleeEnemy(Vector3 position)
    {
        return Instantiate(_enemy, position, Quaternion.Euler(-90,0,0)).SetColor(Color.red).SetHealth(50);
    }

    public Enemy CreateRangedEnemy(Vector3 position)
    {
        return Instantiate(_enemy, position, Quaternion.Euler(-90,0,0)).SetColor(Color.blue).SetHealth(25);
    }
}
