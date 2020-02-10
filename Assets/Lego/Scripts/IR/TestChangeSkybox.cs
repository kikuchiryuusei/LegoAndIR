using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeSkybox : MonoBehaviour
{
    public Material _skyboxMaterial;
    public Material _defaultSkyboxMaterial;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C) || Input.GetKeyDown(KeyCode.Joystick1Button1))//Keyboard:C or Gamepad:ButtonA
        {
            if (i == 0)
            {
                RenderSettings.skybox = _skyboxMaterial;
                i++;
            }
            else
            {
                RenderSettings.skybox = _defaultSkyboxMaterial;
                i = 0;
            }
        }
    }
}
