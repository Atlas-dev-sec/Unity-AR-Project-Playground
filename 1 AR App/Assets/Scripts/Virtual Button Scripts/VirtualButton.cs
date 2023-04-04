using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualButton : MonoBehaviour
{
    public GameObject cube;
    VirtualButtonBehaviour vbutton;
    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);
        vbutton = GetComponentInChildren<VirtualButtonBehaviour>();
        vbutton.RegisterOnButtonPressed(OnButtonPressed);
        vbutton.RegisterOnButtonReleased(OnButtonReleased);
    }

    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }

}
