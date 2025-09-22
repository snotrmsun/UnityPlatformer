using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ��� �����
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        }
    }
}
