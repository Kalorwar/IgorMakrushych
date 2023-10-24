using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour
{
    [SerializeField] public float Amount;

    private void Start()
    {
        transform.localScale = new Vector3(Amount, Amount, Amount);
    }
}
