using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Djed : BasePiece
{
    [HideInInspector]
    public Sprite noHit;
    [HideInInspector]
    public Sprite mirrorHit;
    [HideInInspector]
    public Sprite backHit;
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
            sprites = Resources.LoadAll<Sprite>("Red Djed");
        }
        else
        {
            sprites = Resources.LoadAll<Sprite>("Silver Djed");
        }
        noHit = sprites[0];
        mirrorHit = sprites[1];
        backHit = sprites[2];
        rightHit = sprites[1];
        upHit = sprites[1];
        leftHit = sprites[2];
        downHit = sprites[2];

        GetComponent<Image>().sprite = noHit;
    }

    public override bool Move(Cell target)
    {
        if (Mathf.Abs(myCurrentCell.myBoardPosition[0] - target.myBoardPosition[0]) > 1)
        {
            return false;
        }
        if (Mathf.Abs(myCurrentCell.myBoardPosition[1] - target.myBoardPosition[1]) > 1)
        {
            return false;
        }
        if (target.myCurrentPiece != null)
        {
            if (target.myCurrentPiece.GetType() == typeof(Pyramid) 
                || target.myCurrentPiece.GetType() == typeof(Obelisk))
            {
                Swap(target);
                return true;
            }
            return false;
        }
        myCurrentCell.myCurrentPiece = null;

        myCurrentCell = target;

        myCurrentCell.myCurrentPiece = this;
        transform.position = myCurrentCell.transform.position;
        myPieceManager.SwitchSides();
        return true;
    }

    private void Swap(Cell target)
    {
        BasePiece targetPiece = target.myCurrentPiece;

        targetPiece.myCurrentCell = myCurrentCell;
        myCurrentCell.myCurrentPiece = targetPiece;
        targetPiece.transform.position = myCurrentCell.transform.position;

        myCurrentCell = target;
        myCurrentCell.myCurrentPiece = this;
        transform.position = myCurrentCell.transform.position;

        myPieceManager.SwitchSides();
    }
}
