using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class TextShiftX : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    public string playerSide;
    public void SetSpace()
    {
        buttonText.text = playerSide;
        button.interactable = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
