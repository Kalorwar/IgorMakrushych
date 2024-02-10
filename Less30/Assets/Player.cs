using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Button _buttonStone;
    [SerializeField] private Button _buttonPeper;
    [SerializeField] private Button _buttonScissors;
    [SerializeField] private Timer _timer;
    [SerializeField] private Enemy _enemy;
    
    [field: SerializeField] public bool IsButtonsClick { get; private set; }

    private Choice _playerChoice;
    private Choice _enemyChoice;
    
    private void Awake()
    {
        _buttonPeper.onClick.AddListener(() => OnButtonClick(Choice.Paper));
        _buttonStone.onClick.AddListener(() => OnButtonClick(Choice.Stone));
        _buttonScissors.onClick.AddListener(() => OnButtonClick(Choice.Scissors));
    }
    
    private void OnButtonClick(Choice playerChoice)
    {
        _playerChoice = playerChoice;
        IsButtonsClick = true;
        HideButtons();
        StartCoroutine(TimerTick());
       StartCoroutine(_timer.StartTimer());
    }
    
    private void HideButtons()
    {
        if (IsButtonsClick == true)
        {
            _buttonPeper.gameObject.SetActive(false);
            _buttonScissors.gameObject.SetActive(false);
            _buttonStone.gameObject.SetActive(false);
        }
    }
    
    private void CheckResult(Choice playerChoice, Choice enemyChoice)
    { 
        if ((playerChoice == Choice.Stone && enemyChoice == Choice.Scissors) || 
            (playerChoice == Choice.Scissors && enemyChoice == Choice.Paper) ||
            (playerChoice == Choice.Paper && enemyChoice == Choice.Stone))
        {
            Debug.Log("Победа");
        }
        else
        {
            Debug.Log("Поражение");
        }
    }
    
    private IEnumerator TimerTick()
    {
        yield return new WaitForSeconds(_timer.Duration);
        _enemyChoice = _enemy.SetChoice();
        Debug.Log("Enemy choice:" + _enemyChoice);
        Debug.Log("Your choice:" + _playerChoice);
        CheckResult(_playerChoice, _enemyChoice);
    }
}
public enum Choice 
{
    Stone,
    Scissors,
    Paper
}