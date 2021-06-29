using UnityEngine;

public class MenuUIHandler : MonoBehaviour
{
    public void ChangeName(string playerName)
    {
        MenuManager.Instance.playerName = playerName;
    }
}
