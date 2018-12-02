using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public struct Passenger
{
    public int Id;
    public string Name;
    public int NetWorth;
    public int Weight;
    public bool Alive;

    public Passenger(int id, string name, int netWorth, int weight)
    {
        Id = id;
        Name = name;
        NetWorth = netWorth;
        Weight = weight;
        Alive = true;
    }
}

public class Balloon : MonoBehaviour
{
    public const int kMaxPassengers = 6;

    public BalloonEnvelope Envelope { get; set; }

    public List<Passenger> Passengers { get; set; } = new List<Passenger>();

    public float HeatUpTimeLieft { get; set; }

    private void Awake()
    {
        Envelope = GetComponentInChildren<BalloonEnvelope>();
        Envelope.Balloon = this;
    }

    internal int CalculateWeight()
    {
        // todo: add weights of other parts of the hot air balloon, sans the air in the envelope
        return Passengers.Where(x => x.Alive).Sum(x => x.Weight) + 0;
    }
}
