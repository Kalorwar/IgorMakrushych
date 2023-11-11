using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _gun.CanShoot == true && _gun.Ammo > 0)
        {
            _gun.Shoot();
            _gun.Delay();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _gun.Reload();
        }
    }
}
