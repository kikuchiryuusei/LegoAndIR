using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeLight : MonoBehaviour
{
    int i;
    public float defaultLight = 15f;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Light>().range = defaultLight;

        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0))//Keyboard:Space or Gamepad:ButtonX
        {
            if (i == 0)
            {
                this.GetComponent<Light>().range = 100f;

                i++;
            }
            else
            {
                this.GetComponent<Light>().range = defaultLight;

                i = 0;
            }
        }
    }
}
