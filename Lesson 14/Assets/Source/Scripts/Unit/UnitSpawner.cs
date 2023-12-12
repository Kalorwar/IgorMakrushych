using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnitFabrica))]
public class UnitSpawner : MonoBehaviour
{
    private UnitFabrica _fabrica;
    private List<Unit> _units = new List<Unit>();
    private Coroutine _moveTick;
    private void Awake()
    {
        _fabrica = GetComponent<UnitFabrica>();
    }

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 randomPosition = transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            _units.Add(_fabrica.CreateUnit(randomPosition, transform));
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            _moveTick = StartCoroutine(MoveTick());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           if(_moveTick != null) 
            {
                StopCoroutine(_moveTick);
                _moveTick = null;
            }
        }
    }

    private IEnumerator MoveTick()
    {
        foreach (Unit unit in _units)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1f));
            unit.Move(-Vector3.forward);
        }
    }
}
