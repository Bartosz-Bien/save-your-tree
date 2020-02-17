using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class objectAsButton : MonoBehaviour
{
    void clickerOn()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("test");
        }
    }
}
