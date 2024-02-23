using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent<Player>(out _player))
        {
            _player.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }

    public virtual void Move()
    {
        _rigidbody.velocity = Vector2.left * _speed;
    }
}