using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadControl : MonoBehaviour
{
    public float m_MoveSpeed = 0f;
    public float m_RotateSpeed = 0f;

    void Update()
    {
        Translation();
        Rotation();

        //KeyTest();
    }

    void Translation()
    {
        Vector3 dirX = new Vector3((transform.right.x * Input.GetAxis("L_Stick_H")), (transform.right.y * Input.GetAxis("L_Stick_H")), (transform.right.z * Input.GetAxis("L_Stick_H")));
        Vector3 dirY = new Vector3((transform.forward.x * Input.GetAxis("L_Stick_V")), (transform.forward.y * Input.GetAxis("L_Stick_V")), (transform.forward.z * Input.GetAxis("L_Stick_V")));
        Vector3 dirZ = new Vector3(0f, -Input.GetAxis("R_Stick_V"), 0f);
        transform.position += (dirX + dirY + dirZ) * m_MoveSpeed * Time.deltaTime;
    }

    void Rotation()
    {
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.y += Input.GetAxis("R_Stick_H") * 359f * m_RotateSpeed;
        transform.eulerAngles = eulerAngles;
    }

    void KeyTest()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("button0");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("button1");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button2");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("button3");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("button7");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
        }
        float hori = Input.GetAxis("Horizontal_Pad");
        float vert = Input.GetAxis("Vertical_Pad");
        if ((hori != 0) || (vert != 0))
        {
            Debug.Log("pad:" + hori + "," + vert);
        }

        float test3 = Input.GetAxis("R_Stick_H");//3th axis
        if (test3 != 0)
        {
            Debug.Log("R_Stick_H");
        }
        float test4 = Input.GetAxis("R_Stick_V");//4th axis
        if (test4 != 0)
        {
            Debug.Log("R_Stick_V");
        }
        float test5 = Input.GetAxis("L_Stick_H");//5th axis
        if (test5 != 0)
        {
            Debug.Log("L_Stick_H");
        }
        float test6 = Input.GetAxis("L_Stick_V");//6th axis
        if (test6 != 0)
        {
            Debug.Log("L_Stick_V");
        }
    }
}