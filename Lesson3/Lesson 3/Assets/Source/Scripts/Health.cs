using UnityEngine;

public class Health : MonoBehaviour
{
    public float objectHealth;
     public float Maxhealth;
     
    public void SetHealth(int bonushealth)
    {
        objectHealth += bonushealth;

        if (objectHealth > Maxhealth)
        {
            objectHealth = Maxhealth;

        }
    }
    void Start()
    {
            objectHealth = Maxhealth;
        
    }
}