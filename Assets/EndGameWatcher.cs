using UnityEngine;

public class EndGameWatcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.Win();
        }
    }
}
