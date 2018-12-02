using UnityEngine;
using UnityEngine.UI;

public class UiPassengerPanel : MonoBehaviour
{
    public Text NameText;
    public Text WorthText;
    public Text WeightText;
    public Button ThrowButton;

    public void Fill(Passenger p)
    {
        NameText.text = p.Name;
        WorthText.text = "Worth: $" + p.NetWorth;
        WeightText.text = string.Format("Weight: {0} kg", p.Weight);
        ThrowButton.onClick.AddListener(() => { UiManager.Instance.Throw(p.Id); });
    }
}
