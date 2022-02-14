using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    float power = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && this.rotSpeed == 0)
        {
            power += 0.4f;
        }

        if(Input.GetMouseButtonUp(0) && this.rotSpeed == 0)
        {
            Debug.Log("power level: " + power);
            this.rotSpeed = Random.Range(power,power+5.0f);
            power = 0;
        }

        this.transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.99f;

        if(this.rotSpeed < 0.1f)
        {
            this.rotSpeed = 0;
        }
    }
}
