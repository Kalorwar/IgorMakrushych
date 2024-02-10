using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private Choice[] _choice;

    public Choice SetChoice()
    {
        return _choice[Random.Range(0, _choice.Length)];
    }
}