using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour, IShootable, IMovable
{ 
    [SerializeField] private float _health;
    [SerializeField] private float _speed;
    [SerializeField] private BulletSpawner _bulletSpawner;
    
    private float _maxHealth = 3f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _health = _maxHealth;
    }

    private void Update()
    {
        Move();
        Shoot();
    }

    public void TakeDamage (float amount)
    {
        if (amount < 0)
        { 
            Debug.Log("Damage must be positive");
        }
        else
        {
            _health -= amount;
            Die();
        }
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody.velocity = Vector2.up * _speed;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _rigidbody.velocity = Vector2.down * _speed;
        }

        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) &&
            !Input.GetKey(KeyCode.D))
            _rigidbody.velocity = Vector2.zero;
        
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -10.25f, 10.25f), Mathf.Clamp(transform.position.y, -4, 4));
    }

    private void Die()
    {
        if (_health <= 0)
        Destroy(gameObject);
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _bulletSpawner.CreateBullet();
        }
    }
}