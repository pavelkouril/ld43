using System;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : Singleton<UiManager>
{
    public Text GameEnd;

    public UiPassengerPanel[] PassengerPanels;

    public Text BalloonAltitude;
    public Text PassengerCount;
    public Text TotalWeight;
    public Text TotalNetWorth;
    public Text AirTemperature;
    public Text RemainingHeatupTime;

    private void Awake()
    {
        GameEnd.gameObject.SetActive(false);
    }

    public void SetGameEndText(string text)
    {
        GameEnd.text = text;
    }

    public void Throw(int index)
    {
        Debug.Log("threw" + index);
    }

    public void UpdateStats(float alt, int passengers, int weight, int netWorth, float temperature, float remainingHeatUp)
    {
        BalloonAltitude.text = string.Format("Altitude: {0} m", alt);
        PassengerCount.text = string.Format("Passengers: {0}", passengers);
        TotalWeight.text = string.Format("Total Weight: {0} kg", weight);
        TotalNetWorth.text = string.Format("Total Net Worths: ${0} ", netWorth);
        AirTemperature.text = string.Format("Hot air temperature: {0} K", temperature);
        RemainingHeatupTime.text = string.Format("RemainingHeatup: {0} s", remainingHeatUp);
    }
}
