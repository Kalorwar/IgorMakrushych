using System.Collections;
using UnityEngine;

public class Kalashnikov : Gun
{
    public override void Shoot()
    {
        StartCoroutine(BurstShootTick());
    }
    private void BurstShoot()
    {
        Bullet bulletCreated = Instantiate(_bullet, _spawnPoint.position, Quaternion.identity).GetComponent<Bullet>();
        bulletCreated.Fly(_spawnPoint.transform.forward, 100);
        Ammo--;
    }
    private IEnumerator BurstShootTick()
    {
        BurstShoot();
        yield return new WaitForSeconds(_delay);
        

    }
}
