using UnityEngine;
using UnityEngine.UI;

public class UiManager : Singleton<UiManager>
{
    public Text GameEnd;

    public UiPassengerPanel[] PassengerPanels;

    public void SetGameEndText(string text)
    {
        GameEnd.text = text;
    }

    public void Throw(int index)
    {
        Debug.Log("threw" + index);
    }
}
