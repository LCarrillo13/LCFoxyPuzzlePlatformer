using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    
    public GameObject platform;
    [SerializeField] private Vector3 platformMovement;
    [SerializeField] private int moverSpeed;
    [SerializeField] private float minX = -10.5f;
    [SerializeField] private float maxX = 9.6f;
    [SerializeField] private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }
    
    public void Moving()
    {
        if (transform.position.x > maxX)
        {
            direction = -1;
        }
        else if (transform.position.x < minX)
        {
            direction = 1;
        }
        platformMovement = Vector3.right * direction * moverSpeed * Time.deltaTime;
        transform.Translate(platformMovement);
    }
}
