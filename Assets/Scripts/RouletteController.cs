using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotSpeed = 0; // Rotation speed
    private bool start = false;
    private bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set rotSpeed when press space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.stop != true) this.rotSpeed = 10;
            if (this.start)
            {
                this.stop = true;
            }
            this.start = true;
        }

        // Rotate roulette by rotSpeed
        transform.Rotate(0, 0, this.rotSpeed);

        if (this.stop)
        {
            // Slow down roulette
            this.rotSpeed *= 0.994f;
            if (rotSpeed <= 0.01f)
            {
                this.rotSpeed = 0;
                this.start = false;
                this.stop = false;
            }
        }   
    }
}
