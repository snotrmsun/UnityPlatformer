using UnityEngine;

public class DeathPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            other.transform.position = new Vector3(0, 1, 0);
        }
    }
}
