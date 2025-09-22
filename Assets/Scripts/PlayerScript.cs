using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Скорость движения
    public float Speed = 5f;
    public float JumpForce = 300f;

    void Update()
    {
        // Движение влево-вправо
        float horizontalX = Input.GetAxis("Horizontal");
        transform.Translate(-horizontalX * Speed * Time.deltaTime, 0, 0);

        float horizontalZ = Input.GetAxis("Vertical");
        transform.Translate(0, 0, -horizontalZ * Speed * Time.deltaTime);

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce);
        }
    }
}
