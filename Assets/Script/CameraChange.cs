using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraChange : MonoBehaviour
{
    [SerializeField] GameObject camera;

    public void ChangeGender()
    {   
        camera.transform.Rotate(0, +180f , 0); 
    }
    
}
