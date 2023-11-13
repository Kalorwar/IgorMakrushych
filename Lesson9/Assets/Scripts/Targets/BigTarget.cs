using UnityEngine;

public class BigTarget : Target
{
    public override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bullet>())
        {
            GetComponent<MeshRenderer>().material.color = Color.grey;
            Destroy(collision.gameObject);
        }
    }
}
