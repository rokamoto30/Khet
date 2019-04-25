using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePiece : EventTrigger
{
    #region start
    [HideInInspector]
    public Color mColor = Color.clear;

    protected Cell mOriginaCell = null;
    protected Cell mCurrentCell = null;

    protected RectTransform mRectTransform = null;
    protected PieceManager mPieceManager;

    protected Vector3Int mMovemnt = Vector3Int.one;
    protected List<Cell> mHighlightedCells = new List<Cell>();

    public virtual void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager);
    #endregion
    //New
    #region Movement
    private void CreatCellPath(int xDirection, int yDirection, int movement)
    {
        // target pos
        int currentX = mCurrentCell.mBoardPosition.x;
        int currentY = mCurrentCell.mBoardPosition.y;

        //check cell
        for (int i =1; i <= closestPiece; i++)
        {
            currentX += xDirection;
            currentY += yDirection;
            //add to list
            mHighlightedCells.Add(mCurrentCell.mBoard.mAllCells[currentX, currentY]);

        }
    }
    protected virtual void CheckPathing()
    {
        //hor
        CreatCellPath(1, 0, mMovement.x);
        CreatCellPath(-1, 0, mMovement.x);

        //vert
        CreatCellPath(0, 1, mMovement.y);
        CreatCellPath(0, -1, mMovement.y);

        //up dia
        CreatCellPath(1, 1, mMovement.z);
        CreatCellPath(-1, 1, mMovement.z);

        //low dia
        CreatCellPath(-1, -1, mMovement.z);
        CreatCellPath(1, -1, mMovement.z);

    }
    protected void showCells()
    {
        foreach (Cell cell in mHighlightedCells)
            cell.mOutlineImage.enable = true;

        mHighlightedCells.clear();
    }

    #endregion
    #region Events
    public override void onPush (PointerEventData eventData)
    {
        base.onPush(eventData);

        //Test for cells
        CheckPathing();
    }

    #endregion

}
