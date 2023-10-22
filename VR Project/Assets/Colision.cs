using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Dusman" )
        {
            StartCoroutine(DelayDeactivate());
            
        }
    }

    IEnumerator DelayDeactivate()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
