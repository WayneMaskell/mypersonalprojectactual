using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFlight : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke(nameof(DestroyGameObject), 2.0f);

        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }

    private void DestroyGameObject() { Destroy(gameObject); }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            Destroy(gameObject);
        }
    }
}
