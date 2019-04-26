using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lazer : BasePiece
{
    [HideInInspector]
    public Sprite noFire;
    [HideInInspector]
    public Sprite fire;
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
            sprites = Resources.LoadAll<Sprite>("Red Lazer");
        }
        else
        {
            sprites = Resources.LoadAll<Sprite>("Silver Lazer");
        }

        noFire = sprites[0];
        noHit = sprites[0];
        fire = sprites[0];
        mirrorHit = sprites[1];
        rightHit = sprites[1];
        upHit = sprites[1];
        leftHit = sprites[1]; 
        downHit = sprites[1];

        GetComponent<Image>().sprite = noHit;
    }

    public override bool Move(Cell target)
    {
        return false;
    }

    public override void rotate(bool CCW)
    {
        if (myTeam == "Red") {
            if (myOrientation == 2 && CCW) {
                base.rotate(CCW);
            } else if (myOrientation == 3 && !CCW) {
                base.rotate(CCW);
            }
        } else {
            if (myOrientation == 0 && CCW) {
                base.rotate(CCW);
            } else if (myOrientation == 1 && !CCW) {
                base.rotate(CCW);
            }
        }
    }
}
