using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private protected Rigidbody _rigidbody;
    [SerializeField] private protected BoxCollider _collider;
    [SerializeField] private protected Transform _transform;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<BoxCollider>();    
        _transform =GetComponent<Transform>(); 
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
    }
}
