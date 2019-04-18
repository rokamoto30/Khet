using System;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
    public GameObject mPiecePrefab;

    private List<BasePiece> myRedPieces = null;
    private List<BasePiece> mySilverPieces = null;

    //format is xposition, yposition, orientation
    private Dictionary<string, int[,]> startingPositions = new Dictionary<string, int[,]>()
    {
        {"Red Pyramid", new int[,]
        {
            {7, 7, 3 },
            {2, 6, 2 },
            {0, 4, 0 },
            {7, 4, 3 },
            {0, 3, 3 },
            {7, 3, 0 },
            {6, 2, 3 }
        }
        },
        {"Red Djed", new int[,]
        {
            {4, 4, 0 },
            {5, 4, 1 }
        }
        },
        {"Red Obelisk", new int[,]
        {
            {4, 7, 2 },
            {6, 7, 2 }
        }
        },
        {"Red Lazer", new int[,]
        {
            {0, 7, 2 }
        }
        },
        {"Red Pharoh", new int[,]
        {
            {5, 7, 2 }
        }
        },
        {"Silver Pyramid", new int[,]
        {
            {3, 5, 1 },
            {2, 4, 2 },
            {7, 4, 1 },
            {2, 3, 1 },
            {9, 3, 2 },
            {7, 1, 0 },
            {2, 0, 1 }
        }
        },
        {"Silver Djed", new int[,]
        {
            {4, 3, 1 },
            {5, 3, 0 }
        }
        },
        {"Silver Obelisk", new int[,]
        {
            {3, 0, 0 },
            {5, 0, 0 }
        }
        },
        {"Silver Lazer", new int[,]
        {
            {9, 0, 0 }
        }
        },
        {"Silver Pharoh", new int[,]
        {
            {4, 0, 0 }
        }
        }
    };

}