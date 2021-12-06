using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScreen : MonoBehaviour
{
    [SerializeField]
    private ScreenOrientation _orientation = ScreenOrientation.Landscape;

    private void Awake()
    {
        Screen.orientation = _orientation;
    }
}
