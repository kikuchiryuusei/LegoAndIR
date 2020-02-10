using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeMaterial2 : MonoBehaviour
{
    public Material[] _RGBmaterials;//割り当てるマテリアル.
    public Material[] _IRmaterials;
    private int i;

    [HideInInspector] public bool status_IR;
    [HideInInspector] public List<float> initial_IRgray = new List<float>();

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        status_IR = false;
        for (int i = 0; i < _IRmaterials.Length; i++)
        {
            initial_IRgray.Add(_IRmaterials[i].color.grayscale);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0))//Keyboard:Space or Gamepad:ButtonX
        {
            if (i == 0)
            {
                this.GetComponent<Renderer>().materials = _IRmaterials;

                i++;
                status_IR = true;
            }
            else
            {
                this.GetComponent<Renderer>().materials = _RGBmaterials;

                i = 0;
                status_IR = false;
            }
        }
    }
}