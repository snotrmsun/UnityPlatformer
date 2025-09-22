using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            // Уничтожаем текущий объект
            Destroy(gameObject);
        }
    }
}
