using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardButtonX : MonoBehaviour
{
    public Button button;
    public Sprite newSprite;
    Image myImageComponent;
    public Text buttonText;
    public string playerSide;

    public Vector3 TempButOnePos;
    public Vector3 TempButTwoPos;

    public void ButtonPosition()
    {
        getposition = transform.GetComponent<RectTransform>().position;
    }
    public void SetSpace()
    {
        Vector3 tempPosition = object1.transform.position;
        object1.transform.position = object2.transform.position;
        object2.transform.position = tempPosition;
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
