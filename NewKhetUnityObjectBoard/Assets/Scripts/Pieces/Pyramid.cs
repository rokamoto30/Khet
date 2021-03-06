﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.EventSystems;

public class Pyramid : BasePiece
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
            sprites = Resources.LoadAll<Sprite>("Red Pyramid");
        }
        else
        {
            sprites = Resources.LoadAll<Sprite>("Silver Pyramid");
        }
        noHit = sprites[0];
        mirrorHit = sprites[1];
        rightHit = sprites[1];
        upHit = sprites[1];
        leftHit = sprites[2];
        downHit = sprites[3];

        GetComponent<Image>().sprite = noHit;
    }
}
