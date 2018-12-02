using UnityEngine;

public class BalloonEnvelope : MonoBehaviour
{
    public const float kOutsideAirDensity = 1.2f;
    public const float kDryAirJoules = 287;
    public const float kAtmoPressure = 101300;
    public const float kOutsideTemparetureInKelvin = 293;
    public const float kThickness = 0.01f;
    public const float kNylonLambda = 0.24f;
    public const float kEnveloperRadius = 5;
    public const float kHeatPropertyOfSubstanceJoulesToChange = 1010;
    public const float kDragCoefficient = 0.5f;

    public float Mass;
    public float AirTemperatureInKelvins;
    public float HotAirVolume;

    public Balloon Balloon { get; set; }

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float hotAirDensity = kAtmoPressure / (kDryAirJoules * AirTemperatureInKelvins);
        float upBuoy = (kOutsideAirDensity - hotAirDensity) * HotAirVolume;
        float area = 4 * Mathf.PI * Mathf.Pow(7, 2);
        float energyLoss = kNylonLambda * area * (kOutsideTemparetureInKelvin - AirTemperatureInKelvins) * Time.fixedDeltaTime / kThickness;
        float temperatureChange = energyLoss / (HotAirVolume * hotAirDensity * kHeatPropertyOfSubstanceJoulesToChange);
        AirTemperatureInKelvins += temperatureChange;
        float drag = 0.5f * kDragCoefficient * kOutsideAirDensity * area * Mathf.Pow(_rb.velocity.y, 2);
        Vector3 buyousNewton = -(upBuoy - Mass) * Physics.gravity * Time.fixedDeltaTime;
        _rb.mass = Mass;
        _rb.AddForce(buyousNewton, ForceMode.Acceleration);


    }
}
