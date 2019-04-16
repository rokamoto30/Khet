using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPositions : MonoBehaviour
{
    [HideInInspector]
    public List<List<int>> positions = new List<List<int>>();
    public int x = 0;
    //positions.Add(new List<int>({0, 0});
    //positions = {{0, 0}};
    private void Start()
    {
        for (int y = 0; y < 8; y++)
        {
            positions.Add(new List<int> {0, y});
        }
        positions.Add(new List<int> { 6, 0 });
        positions.Add(new List<int> { 6, 7 });
        foreach (var sublist in positions)
        {
            print(sublist[0] + " " + sublist[1]);
        }
        print("asdf");
    }
}
