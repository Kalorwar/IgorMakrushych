using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Factory : MonoBehaviour
{
    [SerializeField] private float _miningGold;
    [SerializeField] private int _miningGoldDelay;
    [field: SerializeField] public float Gold { get; private set; }

    private void Start()
    {
        StartCoroutine(MiningGold());
    }

    public void ResetGold()
    {
        Gold = 0;
    }
    
    private IEnumerator MiningGold()
    {
        yield return new WaitForSeconds(_miningGoldDelay);
        Gold += _miningGold;
        StartCoroutine(MiningGold());
    }
}