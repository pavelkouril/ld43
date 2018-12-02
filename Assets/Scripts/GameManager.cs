using System.Collections.Generic;
using UnityEngine;

public struct Passenger
{
    public int Id;
    public string Name;
    public int NetWorth;
    public int Weight;

    public Passenger(int id, string name, int netWorth, int weight)
    {
        Id = id;
        Name = name;
        NetWorth = netWorth;
        Weight = weight;
    }
}

public class GameManager : Singleton<GameManager>
{
    private List<Passenger> _passengers = new List<Passenger>();

    private void Start()
    {
        _passengers.Add(new Passenger(1, "X", 120000000, 120));
        _passengers.Add(new Passenger(2, "Y", 1000000, 80));
        _passengers.Add(new Passenger(3, "Z", 1111111, 55));
        _passengers.Add(new Passenger(4, "A", 1111111, 55));
        _passengers.Add(new Passenger(5, "B", 1111111, 55));
        _passengers.Add(new Passenger(6, "C", 1111111, 55));

        for (int i = 0; i < UiManager.Instance.PassengerPanels.Length; i++)
        {
            UiManager.Instance.PassengerPanels[i].Fill(_passengers[i]);
        }
    }

    void Update()
    {

    }

    public void HeatUp()
    {
        Debug.Log("heat up");
    }
}
