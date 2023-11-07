using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    private void Start()
    {
        Health health = new Health();   
        Health maxhealth = new Health();

        health.Amount = 10;
        maxhealth.Amount = 20;

        Debug.Log("Health " + health.Amount);
        Debug.Log("Maxhealth " + maxhealth.Amount);

        maxhealth = health;

        Debug.Log("Maxhealth " + maxhealth.Amount);

        maxhealth.Amount = 50;

        Debug.Log("Health " + health.Amount);

        health.Amount = 100;

        Debug.Log("Maxhealth " + maxhealth.Amount);
        Debug.Log("Health " + health.Amount);





        int a;
        int b;

        a = 10;
        b = 20;

        Debug.Log ("A " + a);
        Debug.Log ("B " + b);

        b = a;

        Debug.Log("B " + b);

        a = 50;

        Debug.Log("A " + a);
        Debug.Log("B " + b);

        b = 30;

        Debug.Log("A " + a);
        Debug.Log("B " + b);

        DebugA(a);
        DebugHealth(ref health.Amount);

        Debug.Log("Maxhealth " + maxhealth.Amount); //Изменяется с ref 
    }
    public class Health
    {
        public float Amount;
    }



    private void DebugA(float value)
    {
        value *= 2;
        Debug.Log ("DebugA " + value.ToString());
    }
    
    private void DebugHealth(ref float value)
    {
        value *= 2;
        Debug.Log("DebugHealth " + value.ToString());
    }
}
