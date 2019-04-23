using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    #region Variables
    public GameObject myCellPrefab;
    public GameObject myVlinePrefab;
    public GameObject myHlinePrefab;

    [HideInInspector]
    public char[,] cellColors = new char[10, 8];
    [HideInInspector]
    public Cell[,] myAllCells = new Cell[10, 8];
    [HideInInspector]
    public Vline[] myVlines = new Vline[9];
    [HideInInspector]
    public Hline[] myHlines = new Hline[7];
    #endregion

    // We create the board here!
    public void Create()
    {
        #region Set cell colors
        
        for (int x = 0; x < cellColors.GetLength(0); x++)
        {
            for (int y = 0; y < cellColors.GetLength(1); y++)
            {
                if (x == 0)
                {
                    cellColors[x, y] = 'r';
                } 
                else if (x == 9)
                {
                    cellColors[x, y] = 's';
                }
                else if (x == 8 && (y == 0 || y == 7))
                {
                    cellColors[x, y] = 'r';
                }
                else if (x == 1 && (y == 0 || y == 7))
                {
                    cellColors[x, y] = 's';
                }
                else
                {
                    cellColors[x, y] = 'b';
                }
            }
        } 

        #endregion

        #region Create
        for (int x = 0; x < myAllCells.GetLength(0); x++)
        {
            for (int y = 0; y < myAllCells.GetLength(1); y++)
            {
                // Create the cell
                GameObject newCell = Instantiate(myCellPrefab, transform);

                // Position
                RectTransform rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((x * 100) + 50, (y * 100) + 50);

                // Setup
                myAllCells[x, y] = newCell.GetComponent<Cell>();
                myAllCells[x, y].Setup(new Vector2Int(x, y), this);
            }
        }
        #endregion

        #region Color
        
        for (int x = 0; x < myAllCells.GetLength(0); x++)
        {
            for (int y = 0; y < myAllCells.GetLength(1); y++)
            {
                Cell cell = myAllCells[x, y].GetComponent<Cell>();
                Image image = cell.GetComponent<Image>();
                if (cellColors[x, y] == 'r')
                {
                    Color red = Color.HSVToRGB(0, 0.8f, 0.8f);
                    image.color = red;
                }
                else if (cellColors[x, y] == 's')
                {
                    Color silver = Color.HSVToRGB(240f / 360f, 0.15f, 0.45f);
                    image.color = silver;
                }
                else
                {
                    image.color = Color.black;
                }  
            }
        } 

        #region Add lines
        
        for (int x = 0; x < myVlines.GetLength(0); x++) {

            // Create the Vline
            GameObject newVline = Instantiate(myVlinePrefab, transform);

            // Position
            RectTransform rectTransform = newVline.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2((x * 100) + 100, 400);

            // Setup
            myVlines[x] = newVline.GetComponent<Vline>();
        }

        for (int y = 0; y < myHlines.GetLength(0); y++)
        {

            // Create the Hline
            GameObject newHline = Instantiate(myHlinePrefab, transform);

            // Position
            RectTransform rectTransform = newHline.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(500, (y * 100) + 100);

            // Setup
            myHlines[y] = newHline.GetComponent<Hline>();
        } 
        #endregion
        #endregion
    }
}