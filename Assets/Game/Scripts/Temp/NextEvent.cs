using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NextEvent : MonoBehaviour
{
    public TextMeshProUGUI txt;

    public void SetTxt(string toWrite)
    {
        txt.text = toWrite;
    }

}
