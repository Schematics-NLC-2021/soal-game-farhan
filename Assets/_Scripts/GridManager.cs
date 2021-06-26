using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePreFab;
    //[SerializeField] private Tile _tileSoalPreFab;
    //[SerializeField] private Tile _tileBg;



    [SerializeField] private Transform _cam;
    [SerializeField] private Transform _backGround;


    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                //if((x == 0 && y == 0) || (x == 0 && y == 1) || (x == 1 && y == 0) || (x == 1 && y == 1))
                //{
                //    var spawnedTileBg = Instantiate(_tileBg, new Vector3(x, y), Quaternion.identity);
                //    spawnedTileBg.name = $"TileBg {x} {y}";
                //}
                //else if(x < 2 || y < 2)
                //{
                //   var spawnedTileSoal = Instantiate(_tileSoalPreFab, new Vector3(x, y), Quaternion.identity);
                //    spawnedTileSoal.name = $"TileSoal {x} {y}";
                //}

                var spawnedTile = Instantiate(_tilePreFab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";




                //var isOffset = (x + y) % 2 == 1;
                //spawnedTile.Init(isOffset);
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
        _backGround.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -9);
    }
}
