using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    public Board myBoard;
    #endregion

    private void Start()
    {
        myBoard.Create();
    }
}
