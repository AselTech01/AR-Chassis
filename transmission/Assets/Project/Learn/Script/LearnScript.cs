using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LearnScript : MonoBehaviour
{
    [HideInInspector] public static string currTitle;
    [HideInInspector] public static int caseNum;
    //Content cnt;
    //protected string currTitle;
    //public string[] title;
    //public static bool pick;
    /*public GameObject VideoPanel;
    public GameObject NotesPanel;
    [SerializeField] private Sprite[] _allSprites;
    [SerializeField] private Image _image;
    private GameObject hidebtn;
    public GameObject[] Subtopics;
    public GameObject listSub;*/
    //[SerializeField] private Button btn;

    // Start is called before the first frame update
    void Start()
    {
        /*hidebtn = GameObject.FindWithTag("Hide");
        hidebtn.SetActive(false);
        VideoPanel.SetActive(false);*/
    }

    public void Title(string title)
    {
        currTitle = title;
        Debug.Log(title);
        //cnt.currTitle = title;
        //Debug.Log(cnt.currTitle);
    }
    public void Case(int num)
    {
        caseNum = num;
    }
    
}
