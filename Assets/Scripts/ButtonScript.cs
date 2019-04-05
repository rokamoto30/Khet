using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonScript : MonoBehaviour
{
    
    public int count = 0;
    public GameObject player;
    public GameObject space;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void playerMove(Button btn)
    {
        if(count == 0)
        {
            Debug.Log("1");
            player = GameObject.Find(btn.name);
            count = 1;
        }
        else
        {
            Debug.Log("2");
            space = GameObject.Find(btn.name);
            player.transform.position = space.transform.position;
            count = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
