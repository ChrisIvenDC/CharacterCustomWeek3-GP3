using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableCharacter : MonoBehaviour
{
    [SerializeField] private BodyPartData[] bodyPartDataArray;


    [System.Serializable]
    public class BodyPartData
    {
        public Mesh[] meshArray;
        public SkinnedMeshRenderer skinnedMeshRenderer;
    }

    public void ChangeHair()
    {
     int meshIndex = System.Array.IndexOf(bodyPartDataArray[0].meshArray, bodyPartDataArray[0].skinnedMeshRenderer.sharedMesh);
     bodyPartDataArray[0].skinnedMeshRenderer.sharedMesh = bodyPartDataArray[0].meshArray[(meshIndex + 1)% bodyPartDataArray[0].meshArray.Length];
    }

    public void ChangeTop()
    {
     int meshIndex1 = System.Array.IndexOf(bodyPartDataArray[1].meshArray, bodyPartDataArray[1].skinnedMeshRenderer.sharedMesh);
     bodyPartDataArray[1].skinnedMeshRenderer.sharedMesh = bodyPartDataArray[1].meshArray[(meshIndex1 + 1) % bodyPartDataArray[1].meshArray.Length];
    }

    public void ChangeBottoms()
    {
        int meshIndex1 = System.Array.IndexOf(bodyPartDataArray[2].meshArray, bodyPartDataArray[2].skinnedMeshRenderer.sharedMesh);
        bodyPartDataArray[2].skinnedMeshRenderer.sharedMesh = bodyPartDataArray[2].meshArray[(meshIndex1 + 1) % bodyPartDataArray[2].meshArray.Length];
    }
}
