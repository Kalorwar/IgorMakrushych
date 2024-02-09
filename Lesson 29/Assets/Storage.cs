using UnityEngine;

public class Storage : MonoBehaviour
{
    [SerializeField] private float _resource;

    public void TakeResource(float resource)
    {
        _resource += resource;
    }
}