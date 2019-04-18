using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class BasePiece : EventTrigger
{
    [HideInInspector]
    public char myTeam;

    protected Cell myCurrentCell = null;
    protected int myOrientation = 0;

    protected RectTransform myRectTransform = null;
    protected PieceManager myPieceManager;

    // New Variables
    // This will be changed on inheriting classes
    protected List<Cell> myHighlightedCells = new List<Cell>();

    public virtual void Setup(char setTeam, Color32 setSpriteColor, PieceManager setPieceManager)
    {
        myPieceManager = setPieceManager;

        myTeam = setTeam;
        GetComponent<Image>().color = setSpriteColor;
        myRectTransform = GetComponent<RectTransform>();
    }

    public void Place(Cell setCell)
    {
        // Cell stuff
        myCurrentCell = setCell;
        myCurrentCell.myCurrentPiece = this;

        // Object stuff
        transform.position = setCell.transform.position;
        gameObject.SetActive(true);
    }
}
