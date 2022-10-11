using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] cellObj;

    public int gridX;
    public int gridY;

    public float offset;

    public GameObject[,] grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[gridX, gridY];

        for(int x = 0; x < gridX; x++)
        {
            for(int y = 0; y < gridY; y++)
            {
                int randObj = (int)Random.Range(0, cellObj.Length);
                GameObject newCell = Instantiate(cellObj[randObj], transform.position, Quaternion.identity);
         
                newCell.transform.position = new Vector3(transform.position.x + x * offset, transform.position.y + y * offset, 0);
                newCell.GetComponent<SpriteRenderer>().color = Random.ColorHSV();

                newCell.GetComponent<Cell>().gridX = x;
                newCell.GetComponent<Cell>().gridY = y;

                grid[x, y] = newCell;
            }
        }  
    }

}
