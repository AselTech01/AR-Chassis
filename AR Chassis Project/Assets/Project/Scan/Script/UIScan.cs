using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doozy.Engine.UI;
using TMPro;

public class UIScan : MonoBehaviour
{
    [SerializeField] UIView overlay;
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI description;
    [SerializeField] UIView descriptionView;
    //[SerializeField] UIView buttonView;
    Coroutine descRoutine;

    public void Show(string name, string desc)
    {
        title.text = name;
        StartCoroutine(description.Typewrite(desc));
        descriptionView.Show();
        //buttonView.Show();
    }

    public void Show(ARObject obj)
    {
        var data = obj.data;
        Show(data.title, data.description);
    }

    public void Hide()
    {
        descriptionView.Hide();
        //buttonView.Hide();
    }

    public void OverlayHide()
    {
        overlay.Hide();
    }
}
