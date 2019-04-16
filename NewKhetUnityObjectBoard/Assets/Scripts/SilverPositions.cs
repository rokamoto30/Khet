using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverPositions : MonoBehaviour
{
    public List<List<int>> positions = new List<List<int>>();
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < 8; y++)
        {
            positions.Add(new List<int>{ 7, y });
        }
        positions.Add(new List<int> { 1, 0 });
        positions.Add(new List<int> { 1, 7 });
        foreach (var sublist in positions)
        {
            print(sublist[0] + " " + sublist[1]);
        }
        print("asdf");
    }
}
