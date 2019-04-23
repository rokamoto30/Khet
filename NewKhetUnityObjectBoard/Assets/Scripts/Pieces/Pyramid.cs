using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class Pyramid : BasePiece
{
    public Sprite noHit;
    public Sprite mirrorHit;
    public Sprite upHit;
    public Sprite rightHit;
    public Sprite downHit;
    public Sprite leftHit;

    public override void Setup(string setTeam, int setX, int setY, int setRot, Board setBoard, PieceManager setPieceManager)
    {
        base.Setup(setTeam, setX, setY, setRot, setBoard, setPieceManager);

        Sprite[] sprites = Resources.LoadAll<Sprite>("Red_Pyramids");
        noHit = sprites[0];
        mirrorHit = sprites[1];
        upHit = sprites[1];
        rightHit = sprites[1];
        downHit = sprites[2];
        leftHit = sprites[3];

        GetComponent<SpriteRenderer>().sprite = noHit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
