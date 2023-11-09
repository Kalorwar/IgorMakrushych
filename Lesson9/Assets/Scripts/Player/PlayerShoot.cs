using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _gun.Shoot();
        }
    }
}
