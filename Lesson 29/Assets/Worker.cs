using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Worker : MonoBehaviour
{
    [SerializeField] private List <Factory> _factory = new List<Factory>();
    [SerializeField] private List<Factory> _emptyFactories = new List<Factory>();

    [SerializeField] private Storage _storage;
    [SerializeField] private float _resource;
    [SerializeField] private float _moveDelay;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void Start()
    {
        StartCoroutine(MoveTick());
    }

    private void RemoveFactory()
    {
        _emptyFactories.Add(_factory.First());
        _factory.Remove(_factory.First());
    }

    private void TakeResource()
    {
        _resource += _factory.First().Gold;
        _factory.First().ResetGold();
    }

    private void GiveResource()
    {
        _storage.TakeResource(_resource);
        _resource = 0;
        ResetFactory();
    }

    private void ResetFactory()
    {
        _factory.AddRange(_emptyFactories);
        _emptyFactories.Clear();
        StartCoroutine(MoveTick());
    }
    
    private void Move()
    {
        if (_factory.Count == 0)
        {
            _rigidbody.DOMove(_storage.transform.position, 2f).OnComplete(GiveResource);
        }
        else
        {
            _rigidbody.DOMove(_factory.First().transform.position, 2f);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Factory>())
        {
            TakeResource();
            RemoveFactory();
            Move();
        }
    }

    private IEnumerator MoveTick()
    {
        yield return new WaitForSeconds(_moveDelay);
        Move();
    }
}