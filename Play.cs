using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;

    public GameObject s;
    public GameObject s1;
    public GameObject s10;
    public GameObject s11;
    public GameObject s2;
    public GameObject s3;

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    public GameObject undbut;
    public GameObject pl;
    public GameObject pl2;

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;

    public GameObject aboba;
    public GameObject aboba1;


    public void Ok()
    {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        pl.SetActive(true);
        pl2.SetActive(true);
        undbut.SetActive(true);
        d.SetActive(false);
        aboba.SetActive(false);
        aboba1.SetActive(false);
    }

    public void Return()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        pl.SetActive(false);
        pl2.SetActive(false);
        undbut.SetActive(false);
        set1.SetActive(false);
        set2.SetActive(false);
        set3.SetActive(false);
        aboba.SetActive(false);
        aboba1.SetActive(false);

        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(false);

        s1.SetActive(false);
        s10.SetActive(false);
        s11.SetActive(false);
    }

    public void Set()
    {
        d.SetActive(false);
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        pl.SetActive(false);
        pl2.SetActive(false);
        undbut.SetActive(true);
        set1.SetActive(true);
        set2.SetActive(true);
        set3.SetActive(true);
        aboba.SetActive(false);
        aboba1.SetActive(false);
    }

    public void Player1()
    {
        SceneManager.LoadScene("LVL1 1");
    }

    public void Player2()
    {
        SceneManager.LoadScene("LVL1");
    }

    public void lvl()
    {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        pl.SetActive(false);
        pl2.SetActive(false);
        undbut.SetActive(true);
        set1.SetActive(false);
        set2.SetActive(false);
        set3.SetActive(false);
        d.SetActive(false);
        aboba.SetActive(true);
        aboba1.SetActive(true);
    }

    public void Uo1()
    {
        undbut.SetActive(true);
        s1.SetActive(true);
        s10.SetActive(true);
        s11.SetActive(true);
        set1.SetActive(false);
        set2.SetActive(false);
        set3.SetActive(false);
    }
    public GameObject p1;
    public void S1()
    {
        p1 = GameObject.Find("Player");
    }
}
