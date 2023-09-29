using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private Transform PlayerCamera;    
     
    [SerializeField] private CharacterController Controller;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Camera cam;
    [Space]
    [SerializeField] private float speed;
    [SerializeField] GameObject mouseTarget;
    private Transform mouseTransform;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        playerTransform = GetComponent<Transform>();
        Controller = GetComponent<CharacterController>();
        mouseTransform = mouseTarget.GetComponent<Transform>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        playerOrientation();
    }

    private void movePlayer()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Controller.Move(movement * Time.deltaTime * speed);
    }
    private void playerOrientation()
    {
        Vector3 mousePosition = new Vector3(mouseTransform.position.x,1, mouseTransform.position.z);
        transform.LookAt(mousePosition);
    }

    
}
