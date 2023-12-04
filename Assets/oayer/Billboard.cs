using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cam;

    void LateUpdate()
    {
        if (cam != null)
        {
            transform.forward = cam.forward;
        }
        else
        {
            // ถ้าไม่พบกล้อง ให้ใช้ Main Camera แทน
            transform.forward = Camera.main.transform.forward;
        }
    }
}
