using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlatform : MonoBehaviour
{
    public LivesDisplay ld;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerScript>(out var player))
        {
            if (ld.LivesLeft > 1)
            {
                other.transform.position = new Vector3(0, 1, 0);
                ld.LivesLeft--;
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
