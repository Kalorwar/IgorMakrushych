using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{ 
    [SerializeField] private float _health;
    [SerializeField] private float _speed;
    
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

    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody.velocity = Vector2.up * _speed;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _rigidbody.velocity = Vector2.down * _speed;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            _rigidbody.velocity = Vector2.right * _speed;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _rigidbody.velocity = Vector2.left * _speed;
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
}