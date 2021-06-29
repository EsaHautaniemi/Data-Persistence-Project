using UnityEngine;
using UnityEngine.UI;

public class HUDHandler : MonoBehaviour
{
    [SerializeField] Text highscoreAndName;

    string playerName;
    int highscore = 0;

    private void Awake()
    {
        if(MenuManager.Instance != null)
        {
            playerName = MenuManager.Instance.playerName;
        }
        else
        {
            playerName = "Player";
        }
    }

    private void Start()
    {
        highscoreAndName.text = $"Highscore: { highscore } Name: { playerName }";
    }

    private void UpdateHighscore(int highscore)
    {
        highscoreAndName.text = $"Highscore: { highscore } Name: { playerName }";
    }

    private void OnEnable()
    {
        MainManager.NewHighscore += UpdateHighscore;
    }

    private void OnDisable()
    {
        MainManager.NewHighscore -= UpdateHighscore;
    }
}
