using UnityEngine;
using UnityEngine.UI;

public class HUDHandler : MonoBehaviour
{
    [SerializeField] Text highscoreAndName;

    private void UpdateHighscore(string playerName, int highscore)
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
