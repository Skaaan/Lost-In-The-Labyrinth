using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class starttrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(){


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
