using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{
    public TextMeshProUGUI LivesText;
    public int LivesLeft = 5;

    void Update()
    {
        LivesText.text = "";
        for (int i = 1; i <= LivesLeft; i++)
        {
            LivesText.text += "♥";
        }
    }
}