using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitleManager : MonoBehaviour
{
    public TMPro.TMP_Text subtitleText;
    public void ShowText(string text, float duration)
    {
        subtitleText.text = text;
        subtitleText.gameObject.SetActive(true);
        StartCoroutine(TimerToHide(duration));
    }
    IEnumerator TimerToHide(float timer)
    {
        yield return new WaitForSeconds(timer);
        subtitleText.gameObject.SetActive(false);
    }
}
