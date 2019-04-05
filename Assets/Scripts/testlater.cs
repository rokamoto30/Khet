using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class testlater : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //player.onClick.AddListener(selectPlayer);
        //space.onClick.AddListener(swap);
    }

    public void selectPlayer()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        //currentPlayer = btn;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
