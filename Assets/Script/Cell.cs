using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public int gridX;
    public int gridY;

    GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myManager = GameObject.Find("Manager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        if (gridX > 0)
        {
            GameObject leftCell = myManager.grid[gridX - 1, gridY];
            Debug.Log("To my left is " + leftCell.transform.name);
        }
        if(gridX < myManager.gridX - 1)
        {
            GameObject rightCell = myManager.grid[gridX + 1, gridY];
            Debug.Log("To my right is " + rightCell.transform.name);
        }
    }
}
