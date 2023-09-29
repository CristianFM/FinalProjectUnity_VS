using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        camaraMovement();   
    }

    private void camaraMovement()
    {
        Vector3 camaraMove = new Vector3(playerTransform.position.x, 30f, playerTransform.position.z -12f);
        transform.position = camaraMove;   
    }
}
