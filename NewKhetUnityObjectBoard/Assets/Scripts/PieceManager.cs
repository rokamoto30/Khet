using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieceManager : MonoBehaviour
{
    public GameObject myPiecePrefab;

    public BasePiece currentSelectedPiece = null;

    [HideInInspector]
    // Starts at false because it gets switched at the beginning of SwitchSides everytime its called.
    public Boolean firstTeamsTurn = false;

    private List<BasePiece> myRedPieces = new List<BasePiece>();
    private List<BasePiece> mySilverPieces = new List<BasePiece>();

    public BasePiece redPharoh;
    public BasePiece silverPharoh;

    //format is xposition, yposition, 
    private Dictionary<string, int[,]> classicStartingPosition = new Dictionary<string, int[,]>()
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
            {9, 4, 1 },
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

    private Dictionary<string, Type> myPieceLibrary = new Dictionary<string, Type>()
    {
        {"Red Pyramid", typeof(Pyramid)},
        {"Silver Pyramid", typeof(Pyramid)},
        {"Red Djed", typeof(Djed)},
        {"Silver Djed", typeof(Djed)},
        {"Red Obelisk", typeof(Obelisk)},
        {"Silver Obelisk", typeof(Obelisk)},
        {"Red Lazer", typeof(Lazer)},
        {"Silver Lazer", typeof(Lazer)},
        {"Red Pharoh", typeof(Pharoh)},
        {"Silver Pharoh", typeof(Pharoh)}
    };

    public void Setup(Board board)
    {
        CreateAndPlacePieces(board);
        SwitchSides();
    }

    private void CreateAndPlacePieces(Board board)
    {
        List<BasePiece> newPieces = new List<BasePiece>();

        foreach(String name in classicStartingPosition.Keys)
        {
            int[,] pieceData = classicStartingPosition[name];
            for (int i = 0; i < pieceData.GetLength(0); i++)
            {
                // Create new object
                GameObject newPieceObject = Instantiate(myPiecePrefab);
                newPieceObject.transform.SetParent(transform);

                // Set scale and position
                newPieceObject.transform.localScale = new Vector3(1, 1, 1);
                newPieceObject.transform.localRotation = Quaternion.identity;

                // Get the type, apply to new object
                Type pieceType = myPieceLibrary[name];
                print("Name: " + name + " type: " + myPieceLibrary[name]);
                BasePiece newPiece = (BasePiece) newPieceObject.AddComponent(pieceType);

                // Store new piece and setup
                if (name.Substring(0, 3) == "Red")
                {
                    myRedPieces.Add(newPiece);
                    newPiece.Setup("Red", pieceData[i, 0], pieceData[i, 1], 
                        pieceData[i, 2], board, this);
                } else
                {
                    mySilverPieces.Add(newPiece);
                    newPiece.Setup("Silver", pieceData[i, 0], pieceData[i, 1], 
                        pieceData[i, 2], board, this);
                }
            }
        }
    }

    public void SwitchSides()
    {
<<<<<<< HEAD
=======
        if (getWinner())
        {
            //TODO do something for winner
        }
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
        firstTeamsTurn = !firstTeamsTurn;
        currentSelectedPiece = null;

        if (firstTeamsTurn)
        {
            foreach (BasePiece piece in myRedPieces)
            {
                piece.GetComponent<Image>().raycastTarget = true;
            }
            foreach (BasePiece piece in mySilverPieces)
            {
                piece.GetComponent<Image>().raycastTarget = false;
            }
        } else
        {
            foreach (BasePiece piece in mySilverPieces)
            {
                piece.GetComponent<Image>().raycastTarget = true;
            }
            foreach (BasePiece piece in myRedPieces)
            {
                piece.GetComponent<Image>().raycastTarget = false;
            }
        }
    }

    public void Update()
    {
        if (currentSelectedPiece == null)
        {
            return;
        }   
        if (Input.GetKey("a"))
        {
            currentSelectedPiece.rotate(true);
        }
        if (Input.GetKey("d"))
        {
            currentSelectedPiece.rotate(false);
        }
    }
<<<<<<< HEAD
=======

    public bool getWinner()
    {
        if (!(redPharoh.alive && silverPharoh.alive)) {
            return true;
        }
        return false;
    }
>>>>>>> 202d6c381576e77ec0147819c07729001741d527
}