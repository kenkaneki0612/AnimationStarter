using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class ButtonEnable : MonoBehaviour
{
    public Button myButton;
    public Sprite buttonDisable;
    // Start is called before the first frame update
    void Start()
    {
        myButton = GetComponent<Button>();
    }

    // Update is called once per frame
    public void changeButton ()
    {
          myButton.image.overrideSprite = buttonDisable;
        Debug.Log("You can click button!");
    }
}
