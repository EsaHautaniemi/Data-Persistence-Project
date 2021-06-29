using UnityEngine;
using UnityEngine.UI;

public class HUDHandler : MonoBehaviour
{
    [SerializeField] Text highscoreAndName;

    int highscore = 0;
    string playerName;

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

    private void UpdateHighscore()
    {
        highscoreAndName.text = $"Highscore: { highscore } Name: { playerName }";
    }
}
