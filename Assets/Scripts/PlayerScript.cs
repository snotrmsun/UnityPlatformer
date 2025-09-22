using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // �������� ��������
    public float Speed = 5f;
    public float JumpForce = 300f;

    void Update()
    {
        // �������� �����-������
        float horizontalX = Input.GetAxis("Horizontal");
        transform.Translate(-horizontalX * Speed * Time.deltaTime, 0, 0);

        float horizontalZ = Input.GetAxis("Vertical");
        transform.Translate(0, 0, -horizontalZ * Speed * Time.deltaTime);

        // ������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce);
        }
    }
}
