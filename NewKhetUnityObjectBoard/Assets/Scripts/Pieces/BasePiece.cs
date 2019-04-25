using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class BasePiece : EventTrigger, IBeginDragHandler, IEndDragHandler
{
    [HideInInspector]
    public string myTeam;
    [HideInInspector]
    public Board myBoard;

    public Cell myCurrentCell = null;
    protected Cell myTargetCell = null;
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

        myRectTransform.sizeDelta = new Vector3(0.32f, 0.32f, 1);
        myRectTransform.localScale = new Vector3(306.25f, 306.24f, 1);

        myOrientation = setRot;

        for (int i = 0; i < setRot; i++)
        {
            myRectTransform.Rotate(0, 0, 90);
        }

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

    public virtual bool Move(Cell target)
    {
        if (target.myCurrentPiece != null)
        {
            return false;
        }
        if (Mathf.Abs(myCurrentCell.myBoardPosition[0] - target.myBoardPosition[0]) > 1)
        {
            return false;
        }
        if (Mathf.Abs(myCurrentCell.myBoardPosition[1] - target.myBoardPosition[1]) > 1)
        {
            return false;
        }

        myCurrentCell.myCurrentPiece = null;
        myCurrentCell = target;
        myCurrentCell.myCurrentPiece = this;

        transform.position = myCurrentCell.transform.position;
        myPieceManager.SwitchSides();
        return true;
    }

    public virtual void rotate(bool CCW)
    {
        if (CCW)
        {
            print("inital orientation: " + myOrientation);
            myOrientation++;
            myOrientation %= 4;
            print("final orientation: " + myOrientation);
            transform.Rotate(0, 0, 90);
        } else
        {
            print("inital orientation: " + myOrientation);
            myOrientation--;
            myOrientation %= 4;
            myOrientation += 4;
            myOrientation %= 4;
            print("final orientation: " + myOrientation);
            transform.Rotate(0, 0, -90);
        }
        transform.position = myCurrentCell.transform.position;
        myPieceManager.SwitchSides();
    }

    #region Drag
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        myPieceManager.currentSelectedPiece = this;
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        //print("Begin drag");
        base.OnBeginDrag(eventData);
    }

    public override void OnDrag(PointerEventData eventData)
    { 
        //print("drag");
        base.OnDrag(eventData);

        // Checked in case rotation happens during drag
        if (GetComponent<Image>().raycastTarget == false)
        {
            return;
        }
        // follow pointer
        transform.position += (Vector3)eventData.delta;
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        //print("enddrag");
        base.OnEndDrag(eventData);

        // Checked in case rotation happens during drag
        if (GetComponent<Image>().raycastTarget == false)
        {
            return;
        }
        foreach (Cell cell in myBoard.myAllCells)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(cell.myRectTransform, Input.mousePosition))
            {
                if (!Move(cell))
                {
                    transform.position = myCurrentCell.transform.position;
                }
            }
        }
    }
    #endregion
}
