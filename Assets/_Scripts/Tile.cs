using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    [SerializeField] private GameObject angka1;
    [SerializeField] private GameObject angka2;
    [SerializeField] private GameObject angka3;
    [SerializeField] private GameObject angka4;
    [SerializeField] private GameObject angka5;
    [SerializeField] private GameObject angka6;
    [SerializeField] private GameObject angka7;
    [SerializeField] private GameObject angka8;
    [SerializeField] private GameObject angka9;

    [SerializeField] private GameObject Black;



    int a = 0;
    int hitam = 0;





    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && a == 0 && hitam == 0)
        {
            angka1.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 1 && hitam == 0)
        {
            angka1.SetActive(false);
            angka2.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 2 && hitam == 0)
        {
            angka2.SetActive(false);
            angka3.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 3 && hitam == 0)
        {
            angka3.SetActive(false);
            angka4.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 4 && hitam == 0)
        {
            angka4.SetActive(false);
            angka5.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 5 && hitam == 0)
        {
            angka5.SetActive(false);
            angka6.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 6 && hitam == 0)
        {
            angka6.SetActive(false);
            angka7.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 7 && hitam == 0)
        {
            angka7.SetActive(false);
            angka8.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 8 && hitam == 0)
        {
            angka8.SetActive(false);
            angka9.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 9 && hitam == 0)
        {
            angka9.SetActive(false);
            a = 0;
        }
        if (Input.GetMouseButtonDown(1) && hitam == 0)
        {
            Black.SetActive(true);
            hitam = 1;
        }
        else if (Input.GetMouseButtonDown(1) && hitam == 1)
        {
            Black.SetActive(false);
            hitam = 0;
        }
    }
}
