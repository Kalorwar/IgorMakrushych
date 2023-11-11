using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private protected Transform _spawnPoint;
    [SerializeField] private protected Bullet _bullet;
    [SerializeField] private protected float _delay;
    [SerializeField] private int _maxAmmo;
    [SerializeField] private protected float ReloadDelay;

    [field: SerializeField] public int Ammo { get; private protected set; }
    [field:SerializeField] public bool CanShoot { get; private protected set; }

    public virtual void Shoot()
    {
    }

    public void Delay()
    {
        StartCoroutine(DelayShoot());
    }

    public void Reload()
    {
        CanShoot = false;
        StartCoroutine(RealoadTick());
    }

    //public void DestroyBullets()
    //{
    //    StartCoroutine(DestroyBulletsTick());
    //}

    private IEnumerator DelayShoot()
    {
        yield return new WaitForSeconds(_delay);
        CanShoot = true;
    }

    private IEnumerator RealoadTick()
    {
        yield return new WaitForSeconds(ReloadDelay);
        Ammo = _maxAmmo;
        CanShoot = true;
    }

   //private IEnumerator DestroyBulletsTick()
   // {
   //     yield return new WaitForSeconds(5);
   //     Destroy(_bullet);
   // }
}