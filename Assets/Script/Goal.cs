using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("You here");
            SceneManager.LoadScene(sceneName);
        }
    }
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
