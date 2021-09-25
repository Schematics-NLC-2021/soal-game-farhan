using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Runtime.InteropServices;

public class GridManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void sendScore(int score);
    [DllImport("__Internal")]
    private static extern bool confirmActionfunc(int score);

    public GameObject canvas;
    public GameObject endCanvas;

    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePreFab;

    [SerializeField] private Transform _cam;
    [SerializeField] private Transform _backGround;

    private Dictionary<Vector2, Tile> tiles;
    int[] kunciJawaban = { 1, 5, 3, 4, 2, 3, -1, 2, 1, -1, -1, 4, 1, 5, 3, 5, 1, -1, 2, 4, 2, -1, 4, 3, 1 }; //kunciJawaban
    int[] jawabanPlayer = new int[25];

    int totalSkor = 0;
    public Text skor;
    [SerializeField] private GameObject skorTeks;

    public AudioSource submitClick;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        tiles = new Dictionary<Vector2, Tile>();
        for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_tilePreFab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                spawnedTile.PosisiAngka(x, y);

                tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
        //_backGround.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -9);

        
    }

    //fungsi cekSkor saat button Done
    public void cekSkor()
    {
        submitClick.Play();
        int index = 0;
        for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                Vector2 pos = new Vector2(x, y);
                if(tiles[pos].hitam == 1)
                {
                    jawabanPlayer[index] = -1;
                }
                else if(tiles[pos].hitam == 0)
                {
                    jawabanPlayer[index] = tiles[pos].a;
                }
                Destroy(tiles[pos]);
                index++;
            }
        }

        //Cek jawaban dengan kunci
        for(int z = 0; z < 25; z++)
        {
            if(jawabanPlayer[z] == kunciJawaban[z])
            {
                totalSkor++;
            }
        }
        skorTeks.SetActive(true);
        skor.text = totalSkor + " of 25";
        canvas.SetActive(false);
        endCanvas.SetActive(true);
        sendScore(totalSkor);
    }
}
