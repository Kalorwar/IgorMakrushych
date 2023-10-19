using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] public float clickDamage;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Health health = new Health();
            health.objectHealth -= clickDamage;
            
                
          
        }
    }
        
      
    






 }
       