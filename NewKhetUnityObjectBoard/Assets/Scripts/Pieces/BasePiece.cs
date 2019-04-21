using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class BasePiece : EventTrigger
{
    [HideInInspector]
    public string myTeam;
    [HideInInspector]
    public Board myBoard;

    protected Cell myCurrentCell = null;
    protected int myOrientation = 0;

    protected RectTransform myRectTransform = null;
    protected PieceManager myPieceManager;

    // New Variables
    // This will be changed on inheriting classes
    protected List<Cell> myHighlightedCells = new List<Cell>();

    public virtual void Setup(string setTeam, int setX, int setY, int setRot,
        Board setBoard, PieceManager setPieceManager)
    {
        myPieceManager = setPieceManager;
        myBoard = setBoard;

        myTeam = setTeam;
        myRectTransform = GetComponent<RectTransform>();

        Place(myBoard.myAllCells[setX, setY]);
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
