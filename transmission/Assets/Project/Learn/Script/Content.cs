using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using Doozy.Engine.UI;

public class Content : LearnScript
{
    [SerializeField] private TMP_Text title;
    [SerializeField] GameObject[] content;
    //[SerializeField] UIView content2;

    // Start is called before the first frame update
    void Start()
    {
        title.text = currTitle;
        Debug.Log(currTitle);

        ChangeScene();
        //content1.Show();

    }

    void ChangeScene()
    {
        switch (caseNum)
        {
            case 1:
                content[0].SetActive(true);
                break;

            case 2:
                content[1].SetActive(true);
                break;

            case 3:
                content[2].SetActive(true);
                break;

            case 4:
                content[3].SetActive(true);
                break;

            case 5:
                content[4].SetActive(true);
                break;

            case 6:
                content[5].SetActive(true);
                break;

            case 7:
                content[6].SetActive(true);
                break;

            default:
                Debug.Log("Default");
                break;
        }
    }
}
