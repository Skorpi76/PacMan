﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour {
    private static int boardWidth = 28;
    private static int boardHeight = 36;
    public GameObject[,] board = new GameObject[boardWidth, boardHeight];

    public int totalPellets = 0;
    public int score = 0;

	void Start () {
        Object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (GameObject o in objects)
        {
            Vector2 pos = o.transform.position;
            if (o.name != "PacMan" && o.name != "Pellets" && o.name != "Nodes" && o.name != "NonNodes" && o.name != "Maze")
            {
                if (o.GetComponent<Tile>() != null)
                {
                    if (o.GetComponent<Tile>().isPellet || o.GetComponent<Tile>().isPellet)
                    {
                        totalPellets++;
                    }
                }
                board[(int)pos.x, (int)pos.y] = o;
            }
        }
	}
	

	void Update () {
		                                    
	}
}
