using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{

    public Slider ProgressBar;
    public Text ProgressText;

    public void Initialize(int maxValue)
    {
        ProgressBar.maxValue = maxValue;
        ProgressBar.value = 0;
        ProgressText.text = "0%";
    }

    public void ProgressUpdate(int progressValue)
    {
        ProgressBar.value = progressValue;
        ProgressText.text = (progressValue / ProgressBar.maxValue) * 100 + "%";
    }

}
