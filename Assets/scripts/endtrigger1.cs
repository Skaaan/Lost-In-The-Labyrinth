using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;


public class endtrigger1 : MonoBehaviour
{
    
    private void OnTriggerEnter()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
