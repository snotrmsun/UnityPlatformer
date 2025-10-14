using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int CurrentScore = 0;

    void Update()
    {
        // ������ ���� ��������� ����� �� ������
        ScoreText.text = "������: " + CurrentScore + " / 15";
    }
}