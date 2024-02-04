using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(EnemyFabrica))]
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<EnemyType> _meleeEnemy;
    [SerializeField] private List<EnemyType> _rangedEnemy;
    
    [SerializeField] private float _delay;

    private float _chance;
    private EnemyFabrica _fabrica;
    private EnemyType _enemyType;

    private void Awake()
    {
        _fabrica = GetComponent<EnemyFabrica>();
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void SetEnemy()
    {
        _chance = Random.Range(0, 100);
        
        if (_chance > 50)
            _enemyType = EnemyType.Melee;
        if (_chance < 50)
            _enemyType = EnemyType.Ranged;
    }
    
    private void CreateEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-9, 9), Random.Range(-3, 3));
        if (_enemyType == EnemyType.Melee)
        {
            _fabrica.CreateMeleeEnemy(randomPosition);
        }
        if (_enemyType == EnemyType.Ranged)
        { 
            _fabrica.CreateRangedEnemy(randomPosition);
        }
        SortingEnemies(_enemyType);
        SetEnemy();
        StartCoroutine(Spawn());
    }

    private void SortingEnemies(EnemyType enemy)
    {
        if (enemy == EnemyType.Melee)
        {
            _meleeEnemy.Add(enemy);
        }
        if (enemy == EnemyType.Ranged)
        {
            _rangedEnemy.Add(enemy);
        }
    }
    
    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_delay);
        CreateEnemy();
    }
}

public enum EnemyType
{
    Melee = 0,
    Ranged = 1
}