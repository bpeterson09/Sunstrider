using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderScript : MonoBehaviour
{

    private SpriteRenderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (rend.isVisible)
        // {
        //    rend.enabled = true;
        //} else
        // {
        //rend.enabled = false;
        //   }
    }

  //  public void OnCollisionStay2D(Collider2D col)
  //  {
    //    print("out");
        //if (col.gameObject.tag == "Loader")
        //{
      //      rend.enabled = true;
       // }
       // col.GetComponent<SpriteRenderer>().enabled = true;
    //}
}
