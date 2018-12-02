using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text GameEnd;

    public void SetGameEndText(string text)
    {
        GameEnd.text = text;
    }
}
