using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Obelisk : BasePiece
{
    [HideInInspector]
    public Sprite noHit;
    [HideInInspector]
    public Sprite mirrorHit;
    [HideInInspector]
    public Sprite upHit;
    [HideInInspector]
    public Sprite rightHit;
    [HideInInspector]
    public Sprite downHit;
    [HideInInspector]
    public Sprite leftHit;

    public override void Setup(string setTeam, int setX, int setY, int setRot, Board setBoard, PieceManager setPieceManager)
    {
        base.Setup(setTeam, setX, setY, setRot, setBoard, setPieceManager);

        Sprite[] sprites;
        if (setTeam == "Red")
        {
            sprites = Resources.LoadAll<Sprite>("Red Obelisk");
        }
        else
        {
            sprites = Resources.LoadAll<Sprite>("Silver Obelisk");
        }
        noHit = sprites[0];
        mirrorHit = sprites[1];
        leftHit = sprites[2];
        downHit = sprites[3];
        rightHit = sprites[4];

        GetComponent<Image>().sprite = noHit;
    }
    public override void OnBeginDrag(PointerEventData eventData)
    {
        print("begin drag");
        base.OnBeginDrag(eventData);
    }
}
