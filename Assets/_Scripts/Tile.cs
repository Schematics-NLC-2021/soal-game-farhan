using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

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

    [SerializeField] private GameObject Black;

    [SerializeField] public Text satu;
    [SerializeField] public Text dua;
    [SerializeField] public Text tiga;
    [SerializeField] public Text empat;
    [SerializeField] public Text lima;
    [SerializeField] public Text enam;

    public AudioSource clickSource;


    public int a = 0;
    public int hitam = 0;


    public void PosisiAngka(int x, int y)
    {
        satu.rectTransform.localPosition = new Vector3((float)(x - 2) * 47.5f, (float)(y - 2) * 47.5f);
        dua.rectTransform.localPosition = new Vector3((float)(x - 2) * 47.5f, (float)(y - 2) * 47.5f);
        tiga.rectTransform.localPosition = new Vector3((float)(x - 2) * 47.5f, (float)(y - 2) * 47.5f);
        empat.rectTransform.localPosition = new Vector3((float)(x - 2) * 47.5f, (float)(y - 2) * 47.5f);
        lima.rectTransform.localPosition = new Vector3((float)(x - 2) * 47.5f, (float)(y - 2) * 47.5f);
        enam.rectTransform.localPosition = new Vector3((float)(x - 2) * 47.5f, (float)(y - 2) * 47.5f);
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
            clickSource.Play();
            angka1.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 1 && hitam == 0)
        {
            clickSource.Play();
            angka1.SetActive(false);
            angka2.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 2 && hitam == 0)
        {
            clickSource.Play();
            angka2.SetActive(false);
            angka3.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 3 && hitam == 0)
        {
            clickSource.Play();
            angka3.SetActive(false);
            angka4.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 4 && hitam == 0)
        {
            clickSource.Play();
            angka4.SetActive(false);
            angka5.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 5 && hitam == 0)
        {
            clickSource.Play();
            angka5.SetActive(false);
            angka6.SetActive(true);
            ++a;
        }
        else if (Input.GetMouseButtonDown(0) && a == 6 && hitam == 0)
        {
            clickSource.Play();
            angka6.SetActive(false);
            angka1.SetActive(true);
            a = 1;
        }

        if (Input.GetMouseButtonDown(1) && hitam == 0)
        {
            clickSource.Play();
            Black.SetActive(true);
            hitam = 1;
            if (a == 1)
            {
                angka1.SetActive(false);
            }
            else if (a == 2)
            {
                angka2.SetActive(false);
            }
            else if (a == 3)
            {
                angka3.SetActive(false);
            }
            else if (a == 4)
            {
                angka4.SetActive(false);
            }
            else if (a == 5)
            {
                angka5.SetActive(false);
            }
            else if (a == 6)
            {
                angka6.SetActive(false);
            }

        }
        else if (Input.GetMouseButtonDown(1) && hitam == 1)
        {
            clickSource.Play();
            Black.SetActive(false);
            hitam = 0;
            if(a == 1)
            {
                angka1.SetActive(true);
            }
            else if (a == 2)
            {
                angka2.SetActive(true);
            }
            else if (a == 3)
            {
                angka3.SetActive(true);
            }
            else if (a == 4)
            {
                angka4.SetActive(true);
            }
            else if (a == 5)
            {
                angka5.SetActive(true);
            }
            else if (a == 6)
            {
                angka6.SetActive(true);
            }
        }
    }
}
