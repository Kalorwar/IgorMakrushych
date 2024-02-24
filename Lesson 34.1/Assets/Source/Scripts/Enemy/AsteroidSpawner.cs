using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidSpawner : MonoBehaviour
{
   [SerializeField] private float _spawnDelay;
   [SerializeField] private float _difficultyUpDelay;
   
   private Enemy _osteroid;
   
   private void Awake()
   {
      _osteroid = Resources.Load<Asteroid>("Asteroid");
   }

   private void Start()
   {
      StartCoroutine(SpawnTick());
      StartCoroutine(RaisingDifficulty());
   }

   private void CreateOsteroid()
   {
      Vector2 position = new Vector2(transform.position.x, Random.Range(-3.5f, 3.5f));
      Instantiate(_osteroid, position, Quaternion.identity);
      StartCoroutine(SpawnTick());
   }

   private IEnumerator SpawnTick()
   {
      yield return new WaitForSeconds(_spawnDelay);
      CreateOsteroid();
   }
   
   private IEnumerator RaisingDifficulty()
   {
      yield return new WaitForSeconds(_difficultyUpDelay);
      _spawnDelay -= 1;
   }
}