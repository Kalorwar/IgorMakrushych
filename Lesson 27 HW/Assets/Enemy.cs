using UnityEngine;

public class Enemy : MonoBehaviour
{
    [field: SerializeField] public float Id { get; private set; }

    private void Awake()
    {
        Id = Random.Range(1, 100);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}