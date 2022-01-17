using TMPro;
using System.Collections;
using System.Text;
using UnityEngine;

public static class TMProExtensions
{
    public static IEnumerator Typewrite<T>(this T label, string text, int step = 3) where T : TMP_Text
    {
        label.text = "";
        if (text == null)
        {
            yield break;
        }
        int stepCount = 0;
        StringBuilder sb = new StringBuilder();
        foreach (var character in text)
        {
            sb.Append(character);
            stepCount++;
            if (stepCount >= step || sb.Length == text.Length)
            {
                yield return null;
                label.text = sb.ToString();
                stepCount = 0;
            }
        }
    }
}
