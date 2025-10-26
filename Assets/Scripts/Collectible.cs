using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreDisplay sd;
    public GameObject CollectParticle;
    void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ��� �����
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            // ���������� ������� ������
            Destroy(gameObject);
            Instantiate(CollectParticle).transform.position = transform.position;
            sd.CurrentScore++;
        }
    }
}
