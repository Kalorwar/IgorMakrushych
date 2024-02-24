using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private Bullet _bullet;

    private void Awake()
    {
        _bullet = Resources.Load<Bullet>("Bullet");
    }

    public void CreateBullet()
    {
        Instantiate(_bullet, transform.position, Quaternion.identity);
    }
}