using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levels : MonoBehaviour
{
    public GameObject b1;
    public GameObject b2;
    public GameObject p1;
    public GameObject p2;
    public GameObject und;

    public void pl1()
    {
        p1.SetActive(true);
        b1.SetActive(false);
        b2.SetActive(false);
}
    public void pl2()
    {
        p2.SetActive(true);
        b1.SetActive(false);
        b2.SetActive(false);
    }
    public void l1()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void l2()
    {
        SceneManager.LoadScene("LVL2");
    }
    public void l3()
    {
        SceneManager.LoadScene("LVL3");
    }
    public void l4()
    {
        SceneManager.LoadScene("LVL4");
    }
    public void l5()
    {
        SceneManager.LoadScene("LVL5");
    }
    public void l6()
    {
        SceneManager.LoadScene("LVL6");
    }
    public void l7()
    {
        SceneManager.LoadScene("LVL7");
    }
    public void l8()
    {
        SceneManager.LoadScene("LVL8");
    }
    public void l9()
    {
        SceneManager.LoadScene("LVL9");
    }
    public void l10()
    {
        SceneManager.LoadScene("LVL10");
    }






    public void l21()
    {
        SceneManager.LoadScene("LVL1 1");
    }
    public void l22()
    {
        SceneManager.LoadScene("LVL2 1");
    }
    public void l23()
    {
        SceneManager.LoadScene("LVL3 1");
    }
    public void l24()
    {
        SceneManager.LoadScene("LVL4 1");
    }
    public void l25()
    {
        SceneManager.LoadScene("LVL5 1");
    }
    public void l26()
    {
        SceneManager.LoadScene("LVL6 1");
    }
}
