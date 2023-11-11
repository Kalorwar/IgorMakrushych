using UnityEngine;

public class Pistol : Gun
{
    public override void Shoot()
    {
      CanShoot = false;
      Bullet bulletCreated = Instantiate(_bullet, _spawnPoint.position, Quaternion.identity).GetComponent<Bullet>();
      bulletCreated.Fly(_spawnPoint.transform.forward, 100);
      Ammo--;
      //DestroyBullets();
    }
}
