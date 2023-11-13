using UnityEngine;

public class Blaster : Gun
{
    public override void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(_spawnPoint.transform.position, _spawnPoint.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
 }
