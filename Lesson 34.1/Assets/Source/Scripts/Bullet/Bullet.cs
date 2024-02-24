using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour, IMovable
{
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Move();
    }

    public void Move()
    {
        _rigidbody.velocity = Vector2.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Destroy(gameObject);
        }
    }
}