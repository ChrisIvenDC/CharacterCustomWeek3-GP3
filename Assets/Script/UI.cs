using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private Button hairButton;
    [SerializeField] private Button topButton;
    [SerializeField] private Button bottomsButton;
    [SerializeField] private CustomizableCharacter customizableCharacter;
    [SerializeField] private CustomizableCharacter customizableCharacter1;

    private void Awake()
    {
        hairButton.onClick.AddListener(() =>
        {
            Debug.Log("Hair button");
            customizableCharacter.ChangeHair();
            customizableCharacter1.ChangeHair();
        });

        topButton.onClick.AddListener(() =>
        {
            Debug.Log("Top button");
            customizableCharacter.ChangeTop();
            customizableCharacter1.ChangeTop();
        });

        bottomsButton.onClick.AddListener(() =>
        {
            Debug.Log("Bottom button");
            customizableCharacter.ChangeBottoms();
            customizableCharacter1.ChangeBottoms();
        });
    }
}
