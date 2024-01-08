using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    public float rotateSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation
        , Quaternion.LookRotation(player.transform.position - transform.position)
        , rotateSpeed * Time.deltaTime);

        //Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce(lookDirection * speed);
        if (Vector3.Distance(transform.position, player.transform.position) < 10) { transform.position += transform.forward * speed * Time.deltaTime; }

    }
}
