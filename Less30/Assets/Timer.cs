using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _timer;
   [SerializeField] private Player _player;
   
   [field :SerializeField] public int Duration { get; private set; }
   
   private void Update()
   {
      _timer.text = Duration.ToString();
   }
   
   public IEnumerator StartTimer()
   {
      for (int i = 0; i < Duration; i++)
      {
         yield return new WaitForSeconds(1);
         Duration--;
      }
   }
}