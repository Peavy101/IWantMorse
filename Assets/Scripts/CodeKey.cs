using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeKey : MonoBehaviour
{

    public Image keyImage;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            keyImage.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            keyImage.color = Color.blue;
        }
    }
}
