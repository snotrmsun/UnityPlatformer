using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ��� �����
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            // ���������� ������� ������
            Destroy(gameObject);
        }
    }
}
