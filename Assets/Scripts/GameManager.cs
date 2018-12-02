using System.Collections.Generic;
using UnityEngine;

public struct Passenger
{
    public string Name;
    public int NetWorth;
    public int Weight;
}

public class GameManager : MonoBehaviour
{
    private List<Passenger> _passengers = new List<Passenger>();

    void Start()
    {

    }

    void Update()
    {

    }

    public void HeatUp()
    {
        Debug.Log("heat up");
    }
}
