using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] public float clickDamage;

    void Update()
    {
     
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hit, 1000))
            {

                GameObject go = hit.collider.gameObject;

               // Health health = gameObject.GetComponent<Health>();
                //health.objectHealth -= clickDamage;

                if (go != null)
                {

                    Debug.Log(go.name);
            
                    Rigidbody rb = go.GetComponent<Rigidbody>();     
                    
                    if (rb != null)
                    {
                        rb.velocity = Vector3.up * 10;
                    }



                }

            }

        }
     
    }
}
