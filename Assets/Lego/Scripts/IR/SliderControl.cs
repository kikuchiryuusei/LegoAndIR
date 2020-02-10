using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    private float SliderOnly;

    // Start is called before the first frame update
    void Start()
    {
        SliderOnly = GameObject.Find("Slider").GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {
        Controll();
        float _slider = GameObject.Find("Slider").GetComponent<Slider>().value;

        if (_slider == SliderOnly)
        {
            GameObject.Find("FreeCamera").GetComponent<FreeCamera>().enabled = true;
        }

        SliderOnly = _slider;
    }

    public void Method()
    {
        GameObject.Find("FreeCamera").GetComponent<FreeCamera>().enabled = false;
    }

    private void Controll()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            GameObject.Find("Slider").GetComponent<Slider>().value += 0.5f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject.Find("Slider").GetComponent<Slider>().value -= 0.5f;
        }

        if (Input.GetAxis("Vertical_Pad") == 0)
        {
            GameObject.Find("Slider").GetComponent<Slider>().value += (Input.GetAxis("Horizontal_Pad") / 2);
        }
    }
}
