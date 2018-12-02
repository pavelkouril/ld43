using System.Linq;
using UnityEngine;



public class GameManager : Singleton<GameManager>
{
    public GameObject BalloonPrefab;

    public Transform SpawnPoint;

    public float MaxHeatUpTime;

    public Balloon Balloon { get; set; }

    private void Awake()
    {
        var balloonGo = GameObject.Instantiate(BalloonPrefab, SpawnPoint.position, Quaternion.identity, SpawnPoint);
        Balloon = balloonGo.GetComponent<Balloon>();

        Balloon.Passengers.Add(new Passenger(1, "X", 120000000, 120));
        Balloon.Passengers.Add(new Passenger(2, "Y", 1000000, 80));
        Balloon.Passengers.Add(new Passenger(3, "Z", 1111111, 55));
        Balloon.Passengers.Add(new Passenger(4, "A", 1111111, 55));
        Balloon.Passengers.Add(new Passenger(5, "B", 1111111, 55));
        Balloon.Passengers.Add(new Passenger(6, "C", 1111111, 55));

        Balloon.HeatUpTimeLieft = MaxHeatUpTime;

        for (int i = 0; i < Balloon.kMaxPassengers; i++)
        {
            UiManager.Instance.PassengerPanels[i].Fill(Balloon.Passengers[i]);
        }
    }

    void Update()
    {
        UiManager.Instance.UpdateStats(Balloon.transform.position.y, Balloon.Passengers.Count(x => x.Alive), Balloon.CalculateWeight(), Balloon.Passengers.Where(x => x.Alive).Sum(x => x.NetWorth), Balloon.Envelope.AirTemperatureInKelvins, Balloon.HeatUpTimeLieft);
    }

    public void HeatUp()
    {
        Debug.Log("heat up");
    }
}
