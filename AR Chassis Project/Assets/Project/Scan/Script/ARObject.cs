using UnityEngine;

public class ARObject : MonoBehaviour
{
    public ObjectData data;
    public string title => data?.title;
    public string description => data?.description;

    //public ARMainObject mainObject { get; private set; }

    void Awake()
    {
        //mainObject = GetComponent<ARMainObject>();
    }
}