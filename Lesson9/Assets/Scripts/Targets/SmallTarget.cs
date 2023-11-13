using UnityEngine;

public class SmallTarget : Target
{
    public override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bullet>())
        {
            _transform.localScale += new Vector3(1, 1, 1);
            Destroy(collision.gameObject);
        }
    }
}
