using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyect : MonoBehaviour
{
    public GameObject proyectiles;
    public float spawnT = 15f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(proyectiles_cant());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawn_proyectiles(){
        GameObject p = Instantiate(proyectiles) as GameObject;
        p.transform.position = new Vector2(2,Random.Range(-2,2));

    }
    IEnumerator proyectiles_cant(){
        while(true){
            yield return new WaitForSeconds(spawnT);
            spawn_proyectiles();
        }

    }
}
