using System.Collections.Generic;
using UnityEngine;

public struct Passenger
{
    public string Name;
    public int NetWorth;
    public int Weight;

    public Passenger(string name, int netWorth, int weight)
    {
        Name = name;
        NetWorth = netWorth;
        Weight = weight;
    }
}

public class GameManager : MonoBehaviour
{
    private List<Passenger> _passengers = new List<Passenger>();

    private void Start()
    {
        _passengers.Add(new Passenger("X", 120000000, 120));
        _passengers.Add(new Passenger("Y", 1000000, 80));
        _passengers.Add(new Passenger("Z", 1111111, 55));
    }

    void Update()
    {

    }

    public void HeatUp()
    {
        Debug.Log("heat up");
    }
}
