using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderLabel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI progressLabel;

    public void ShowPercent(float value) {
        progressLabel.text = value.ToString("P0");
    }
}
