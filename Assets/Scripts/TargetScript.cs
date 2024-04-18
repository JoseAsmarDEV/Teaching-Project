using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetScript : MonoBehaviour
{
    public Button winButton;
    public TextMeshProUGUI winText;

    public void Win()
    {
        winButton.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
    }
}
