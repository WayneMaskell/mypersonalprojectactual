using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfSpawn : MonoBehaviour
{
    public float delay = 2;
    public float interval = 2;
    public GameObject wolf;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWolf", delay, interval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnWolf() 
    {
        Vector3 position = new Vector3(Random.Range(100f, 0), 0.5f, (Random.Range(100f, 0)));
        Instantiate(wolf, position, transform.rotation);
    }
}
