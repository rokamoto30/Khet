using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    #region Variables
    public Image myOutlineImage;

    [HideInInspector]
    public Vector2Int myBoardPosition = Vector2Int.zero;
    [HideInInspector]
    public Board myBoard = null;
    [HideInInspector]
    public RectTransform myRectTransform = null;
    [HideInInspector]
    public BasePiece myCurrentPiece = null;
    #endregion

    #region Setup
    public void Setup(Vector2Int setBoardPosition, Board setBoard)
    {
        myBoardPosition = setBoardPosition;
        myBoard = setBoard;

        myRectTransform = GetComponent<RectTransform>();
    }
    #endregion
}   