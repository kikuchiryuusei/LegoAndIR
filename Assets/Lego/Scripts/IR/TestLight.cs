using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLight : MonoBehaviour
{
    private Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.Joystick1Button2))//Keyboard:V or Gamepad:ButtonB
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}