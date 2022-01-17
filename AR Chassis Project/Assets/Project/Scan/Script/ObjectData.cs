using UnityEngine;

[CreateAssetMenu(menuName = "ObjectData", fileName = "NewObject")]
public class ObjectData : ScriptableObject
{
    [Header("Text")]
    public string title;
    [TextArea] public string description;

    [Header("Audio")]
    public AudioClip descriptionAudio;
}
