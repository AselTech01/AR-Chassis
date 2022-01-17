using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine.UI;
using TMPro;

public class RayCast : MonoBehaviour
{
    [SerializeField] ARObject ObjData;
    [SerializeField] TextMeshProUGUI description;
    Coroutine descRoutine;

    void OnMouseDown()
    {
        Show(ObjData);
    }

    public void Show(string name, string desc)
    {
        //title.text = name;
        if (descRoutine != null)
        {
            StopCoroutine(descRoutine);
        }
        descRoutine = StartCoroutine(description.Typewrite(desc));
        //descriptionView.Show();
        //buttonView.Show();
    }

    public void Show(ARObject obj)
    {
        var data = obj.data;
        Show(data.title, data.description);
    }
}
