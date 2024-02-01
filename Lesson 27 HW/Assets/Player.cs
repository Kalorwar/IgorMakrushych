using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemies = new List<Enemy>();

    [SerializeField] private float _chance;
    private void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (Input.GetKeyDown(KeyCode.Space) && enemy.Id % 2 == 1)
            {
                enemy.Die();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
             _chance = Random.Range(0, 100);
        }
        
        if (Input.GetKeyDown(KeyCode.F) && _chance < 31)
        {
            int id = Random.Range(0, _enemies.Count);
            _enemies[id].Die();
            _enemies.RemoveAt(id);
        }
    }
}