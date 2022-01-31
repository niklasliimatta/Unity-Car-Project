using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public GameObject[] lanes;

    public int currentLane;
    void Start()
    {
        Debug.Log(lanes.Length);
        var rand = Random.Range(0, lanes.Length);
        Debug.Log(rand);
        transform.position = lanes[rand].transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        var move = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (move > 0 && currentLane != 3)
            {
                currentLane = currentLane + 1;
                
            }
           

        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            if (move < 0 && currentLane != 0)
            {
                currentLane = currentLane - 1;
                
            }
            
            
        }
        
        transform.position = lanes[currentLane].transform.position;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Lane 1")
        {
            currentLane = 0;
        }

        if (other.tag == "Lane 2")
        {
            currentLane = 1;
        }

        if (other.tag == "Lane 3")
        {
            currentLane = 2;
        }

        if (other.tag == "Lane 4")
        {
            currentLane = 3;
        }
    }
}
