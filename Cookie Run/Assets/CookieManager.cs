using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieManager : MonoBehaviour
{
    public int CookieCount = 0;
    public static CookieManager instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void AddCookies()
    {
        CookieCount++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
