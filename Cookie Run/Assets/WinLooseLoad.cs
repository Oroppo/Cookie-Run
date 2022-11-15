using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinLooseLoad : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y < -45)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "wew")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
