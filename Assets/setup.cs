using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setup : MonoBehaviour
{
    public void Setup(){
        this.gameObject.SetActive(true);
    }

    public void restart(){
        SceneManager.LoadScene("SampleScene");
    }
}
