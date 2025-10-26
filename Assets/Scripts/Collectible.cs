using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreDisplay sd;
    public GameObject CollectParticle;
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            // Уничтожаем текущий объект
            Destroy(gameObject);
            Instantiate(CollectParticle).transform.position = transform.position;
            sd.CurrentScore++;
        }
    }
}
