using UnityEngine;
using TMPro;

public class StartMessageController : MonoBehaviour
{
    public TextMeshProUGUI startText;
    public float displayTime = 5f;

    void Start()
    {
        if (startText != null)
        {
            startText.gameObject.SetActive(true);
            Invoke("HideMessage", displayTime);
        }
    }

    void HideMessage()
    {
        startText.gameObject.SetActive(false);
    }
}

