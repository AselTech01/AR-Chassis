using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScanManager : MonoBehaviour
{
    public GameObject point;

    [SerializeField] UIToggle ToggleButton1, ToggleButton2;
    [SerializeField] UIScan scanUI;

    private Transform _selection;

    Animator getAnim;
    public GameObject[] _objAnimation;
    
    [HideInInspector] public bool select;

    [SerializeField] TMP_Text selectText;
    //private string animate = "";
    public static string currAnim;

    [SerializeField] Material highlightMaterial;
    [SerializeField] Material baseMaterial;
    [SerializeField] Material transparent;

    [HideInInspector] public static int ImgTarget;
    //[SerializeField] private TMP_Text Title;

    
    void Start()
    {
        scanUI.Hide();
        selectText.enabled = false;
        point.SetActive(false);
    }

    public void LoadScenes(string sceneName)
    {
        StartCoroutine(LoadSceneRoutine(sceneName));
    }

    IEnumerator LoadSceneRoutine(string sceneName)
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(sceneName);
    }

    public void _ImageTarget(int it)
    {
        ImgTarget = it;
    }

    /*
    public void _Title(string title_)
    {
        Title.text = title_;
    }*/

    void Update()
    {
        if (_selection != null)
        {
            foreach (GameObject _obj in _objAnimation)
            {
                var renderers = _obj.GetComponentsInChildren<Renderer>();
                foreach (var renderer in renderers)
                {
                    renderer.material = baseMaterial;
                }
            }

            _selection = null;
        }

        if (select)
        {
            var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;

                if (selection.gameObject.tag == "components")
                {
                    var renderers = selection.GetComponentsInChildren<Renderer>();
                    foreach (var renderer in renderers)
                    {
                        renderer.material = highlightMaterial;
                    }

                    scanUI.Show(selection.GetComponent<ARObject>());
                    selectText.enabled = false;
                    //animate = "";

                    _selection = selection;
                }

                else
                {
                    selectText.enabled = false;
                    //animate = "";
                }
            }
        }
    }


    public void Explode()
    {
        switch (ImgTarget)
        {
            case 1:
                getAnim = _objAnimation[0].GetComponent<Animator>();

                if (ToggleButton1.IsOn)
                {
                    getAnim.Play("explode");
                }

                else
                {
                    getAnim.Play("assemble");
                }

                break;

            case 2:
                getAnim = _objAnimation[1].GetComponent<Animator>();

                if (ToggleButton1.IsOn)
                {
                    getAnim.Play("explode");
                }

                else
                {
                    getAnim.Play("assemble");
                }
                
                break;

            case 3:
                getAnim = _objAnimation[2].GetComponent<Animator>();

                if (ToggleButton1.IsOn)
                {
                    getAnim.Play("explode");
                }

                else
                {
                    getAnim.Play("assemble");
                }

                break;

            case 4:
                getAnim = _objAnimation[3].GetComponent<Animator>();

                if (ToggleButton1.IsOn)
                {
                    getAnim.Play("explode");
                }

                else
                {
                    getAnim.Play("assemble");
                }

                break;

            case 5:
                getAnim = _objAnimation[4].GetComponent<Animator>();

                if (ToggleButton1.IsOn)
                {
                    getAnim.Play("explode");
                }

                else
                {
                    getAnim.Play("assemble");
                }

                break;

            case 6:
                getAnim = _objAnimation[5].GetComponent<Animator>();

                if (ToggleButton1.IsOn)
                {
                    getAnim.Play("explode");
                }

                else
                {
                    getAnim.Play("assemble");
                }

                break;

            default:
                Debug.Log("Default");
                break;
        }
    }

    public void Select()
    {
        if (ToggleButton2.IsOn)
        {
            select = true;
            point.SetActive(true);

            Debug.Log("Select");
        }

        else
        {
            selectText.enabled = false;
            select = false;
            point.SetActive(false);
            Debug.Log("Diselect");
        }
    }

    /*
    public void Animate()
    {
        currAnim = animate;

        if (currAnim != "")
            LoadScenes("ExtendScan");
    }*/

    public void ModelLost(GameObject main)
    {
        var renderers = main.GetComponentsInChildren<Renderer>();
        foreach (var renderer in renderers)
        {
            renderer.material = transparent;
        }
    }

    public void ModelMaterial(GameObject main)
    {
        StartCoroutine(LoadModelMaterial(main));
    }

    IEnumerator LoadModelMaterial(GameObject main)
    {
        yield return new WaitForSeconds(0.5f);
        var renderers = main.GetComponentsInChildren<Renderer>();
        foreach (var renderer in renderers)
        {
            renderer.material = baseMaterial;
        }
    }
}
