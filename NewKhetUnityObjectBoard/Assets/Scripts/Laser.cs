using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    /*
    public void pathFinder(int currentX, int currentY, int currentAxis)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            #region min
            int min;
            if (currentAxis <= 1)
            {
                min = 1;
            }
            if (currentAxis >= 2)
            {
                min = -1;
            }
            #endregion

            #region terminate bounds
            if (currentX > 9 || currentY > 7 || currentX < 0 || currentY < 0)
            {
                return;
            }
            #endregion

            #region encounter
            if (encounterPiece == true)
            {
                if (destructable(mCurrentPiece) == 1)
                {
                    mCurrentPiece.Kill();
                    return;
                }
                if (obolisttemp == tru)
                {
                    return;
                }
                else
                {
                    if ()
                    {
                        currentAxis = currentAxis - 1;
                    }
                    if ()
                    {
                        currentAxis = currentAxis + 1;
                    }
                    if ()
                    {
                        currentAxis = 0;
                    }
                    if ()
                    {
                        currentAxis = 2;
                    }
                }
            }
            #endregion


            #region recersiveStep
            if (currentAxis == 1 || currentAxis == 3)
            {
                pathFinder(currentX, currentY += min, currentAxis);
            }
            if (currentAxis == 2 || currentAxis == 4)
            {
                pathFinder(currentX += min, currentY += min, currentAxis);
            }
            #endregion
        }
    }
    public int destructable(piece currentPiece)
    {
        if (Piece == destructableCheck)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    } */
}
