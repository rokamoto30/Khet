using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

public class Laser : BasePiece
{
=======

public class Laser : MonoBehaviour
{
    /*
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
    public void pathFinder(int currentX, int currentY, int currentAxis)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            #region min
            int min;
<<<<<<< HEAD
            if (currentAxis == 3 || currentAxis == 0)
            {
                min = 1;
            }
            if (currentAxis == 2 || currentAxis == 1)
=======
            if (currentAxis <= 1)
            {
                min = 1;
            }
            if (currentAxis >= 2)
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
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
<<<<<<< HEAD
            if (mCurrentPiece != null)
            {
                if (mCurrentPiece == Djed || myCurrentPiece == Pyramid)
                {
                    if (currentAxis == ((mCurrentPiece.setRot +1) % 4))
                    {
                        currentAxis = currentAxis - 1;
                    }
                    if (currentAxis == ((mCurrentPiece.setRot + 2) % 4))
                    {
                        currentAxis = currentAxis + 1;
                    }
                    if (mCurrentPiece == Djed && currentAxis == ((mCurrentPiece.setRot - 1) % 4))
                    {
                        currentAxis = currentAxis - 1;
                    }
                    if (mCurrentPiece == Djed && currentAxis == mCurrentPiece.setRot)
                    {
                        currentAxis = currentAxis + 1;
                    }
                }
                else if (mCurrentPiece == Obelisk)
                {
                    if(currentAxis == ((mCurrentPiece.setRot + 2) % 4))
                    return;
                }
                else
                {
                    mCurrentPiece.Kill();
                    return;
                }
=======
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
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
            }
            #endregion


            #region recersiveStep
            if (currentAxis == 1 || currentAxis == 3)
            {
                pathFinder(currentX, currentY += min, currentAxis);
            }
            if (currentAxis == 2 || currentAxis == 4)
            {
<<<<<<< HEAD
                pathFinder(currentX += min, currentY, currentAxis);
=======
                pathFinder(currentX += min, currentY += min, currentAxis);
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
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
<<<<<<< HEAD
    }
=======
    } */
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
}
