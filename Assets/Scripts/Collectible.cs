using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreDisplay sd;
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            // Уничтожаем текущий объект
            Destroy(gameObject);
            sd.CurrentScore++;
        }
    }
}
