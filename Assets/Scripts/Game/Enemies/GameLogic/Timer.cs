using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TXP;

    public int minutes;
    public int seconds;

    private void Start()
    {
        StartCountdown();
    }
    void StartCountdown()
    {
        StartCoroutine(CountdownCoroutine());
    }

    System.Collections.IEnumerator CountdownCoroutine()
    {
        float currentTime = 0;
        while (currentTime <= 1500)
        {
            minutes = Mathf.FloorToInt(currentTime / 60);
            seconds = Mathf.FloorToInt(currentTime % 60);

            TXP.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            currentTime++;
            yield return new WaitForSeconds(1f);
        }
        TXP.text = "Immortal Boss!!!!";
    }
}