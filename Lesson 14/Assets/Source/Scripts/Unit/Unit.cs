using System.Net.Sockets;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Unit : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigitbody;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody>(); 
    }

    public void Move(Vector3 direction)
    {
        _rigitbody.AddForce(direction * _speed, ForceMode.Impulse);
    }
}
