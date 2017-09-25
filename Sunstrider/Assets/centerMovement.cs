using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerMovement : MonoBehaviour {

    private Vector3 direction;
    private float speed;
    public GameObject player;
    public playerScript playerInfo;


    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(player.transform.position.x + 3.72f, 0, 0);
        speed = 0.04f;
        direction = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(0, 0, 0);
     //   if (Input.touchSupported == true)
   //     {
    //        if (Input.GetTouch(0).phase == TouchPhase.Stationary)
      //      {
      //          direction = new Vector3(0.055f, 0, 0);
      //      }
      //          direction = new Vector3(0, 0, 0);
     //   }
     //   else
     //   {
            if (Input.GetKey("space") && playerInfo.getControl())
            {
                direction = new Vector3(0.07f, 0, 0);
            } else if (!playerInfo.getControl())
            {
                transform.position = new Vector3(player.transform.position.x + 3.72f, 0, 0);
            }
            else
            {    
                direction = new Vector3(0, 0, 0);
            }
     //   }
        transform.position += direction;
    }

    public void Reset()
    {
        transform.position = new Vector3(player.transform.position.x + 3.72f, 0,0);
    }

}
