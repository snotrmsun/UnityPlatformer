using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreDisplay sd;
    void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ��� �����
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            // ���������� ������� ������
            Destroy(gameObject);
            sd.CurrentScore++;
        }
    }
}
