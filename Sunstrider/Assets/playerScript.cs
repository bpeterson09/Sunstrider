using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour {

    public Vector3 direction;
    public float speed;
    public float forward;
    public Rigidbody2D rb;
    public GameObject spawnPoint;
    public centerMovement center;
    public AudioClip explosion;
    public AudioClip bounce;
    
    private bool status = true;
    private SpriteRenderer render;
    private nextSpawn checkpoint;
    private bool control = true;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        speed = 0.06f;
        direction = new Vector3(0, speed, 0);
        audio = GetComponent<AudioSource>();
}
	
	// Update is called once per frame
	void Update () {
        //direction = new Vector3(0, speed, 0);
     //   if (Input.touchSupported == true)
      //  {
   //         if (Input.GetTouch(0).phase == TouchPhase.Stationary && status)
          //  {
        //        direction = new Vector3(0.055f, speed, 0);
        //    }
        //    else
         //   {
         //       direction = new Vector3(0, speed, 0);
         //   }
          //  if (Input.GetTouch(0).phase == TouchPhase.Stationary && !status)
      //      {
       //         render = this.GetComponent<SpriteRenderer>();
       //         render.enabled = true;
       //         transform.position = spawnPoint.transform.position;
       //         center.Reset();
         //       status = true;
        //        direction = new Vector3(0, speed, 0);
         //   }
       // } else
     //   {
            if (Input.GetKey("space") && status && control)
            {
                forward = 0.07f;
                //direction = new Vector3(forward, speed, 0);
            }
            else if (status && control)
            {
                forward = 0.0f;
                //direction = new Vector3(0, speed, 0);
            }
            if (Input.GetKey("space") && !status)
            {
                render = this.GetComponent<SpriteRenderer>();
                render.enabled = true;
                transform.position = spawnPoint.transform.position;
                center.Reset();
                status = true;
                direction = new Vector3(0, speed, 0);
            }
        //    }
        direction = new Vector3(forward, speed, 0);
        rb = GetComponent<Rigidbody2D>();
        transform.position += direction;
        transform.rotation = Quaternion.Euler(0, 0, 270);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("hey");
        if (col.gameObject.tag == "Wall") {
            speed = speed * -1;
            //AudioSource.PlayClipAtPoint(bounce, transform.position);
            audio.PlayOneShot(bounce, 0.2f);
            //Debug.Log("it hit");
        }

        if (col.gameObject.tag == "Spikes")
        {
            //AudioSource.PlayClipAtPoint(explosion, transform.position);
            audio.PlayOneShot(explosion, 0.2f);
            status = false;
            render = this.GetComponent<SpriteRenderer>();
            render.enabled = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Checkpoint")
        {
            checkpoint = col.gameObject.GetComponent<nextSpawn>();
            spawnPoint = checkpoint.getSpawn();
            //Debug.Log("checkpoint");
        }
        if (col.gameObject.tag == "SecretCave")
        {
            SceneManager.LoadScene("SecretCave");
        }
        if (col.gameObject.tag == "Next")
        {
            SceneManager.LoadScene("Snowfall");
        }

        if (col.gameObject.tag == "Final")
        {
            SceneManager.LoadScene("CaveRun");
        }

        if (col.gameObject.tag == "Restart")
        {
            SceneManager.LoadScene("Sunstrider");
        }
                if (col.gameObject.tag == "SunstriderExit")
        {
            SceneManager.LoadScene("SunstriderExit");
        }

        if (col.gameObject.tag == "Ice")
        {
            control = false;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Ice")
        {
            control = true;
        }
    }

    public bool getControl()
    {
        return control;
    }

    public bool getStatus()
    {
        return status;
    }
}
