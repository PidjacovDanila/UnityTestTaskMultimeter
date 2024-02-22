using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RotationObjLogic : MonoBehaviour
{
    private bool IsActive;
    private void OnMouseEnter()
    {
        IsActive = true;
    }
    private void OnMouseExit()
    {
        IsActive = false;
    }

    private int phase = 0;
    void Update()
    {
        if (phase == 1)
        {
            MultimeterLogic.instance.OutputV_();
        }
        if (phase == 2)
        {
            MultimeterLogic.instance.OutputV();
        }
        if (phase == -2)
        {
            MultimeterLogic.instance.OutputA();
        }
        if (phase == -1)
        {
            MultimeterLogic.instance.OutputR();
        }
        if (phase == 0)
        {
            MultimeterLogic.instance.Reset_TMP();
        }

        if (IsActive == true)
        {
            float mw = Input.GetAxis("Mouse ScrollWheel");
            if (mw > 0.1 && phase < 2)
            {
                phase++;
                transform.rotation *= Quaternion.AngleAxis(45.0F,Vector3.right);
            }
            if (mw < -0.1 && phase > -2)
            {
                phase--;
                transform.rotation *= Quaternion.AngleAxis(45.0F, Vector3.left);
            }
        }
    }
}
