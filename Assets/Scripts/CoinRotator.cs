using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    public float RotationSpeed = 50f;

    void Update()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }
}
