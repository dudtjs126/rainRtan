using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_rain : MonoBehaviour
{
    int minusscore;
    void Start()
    {
        float size = 0.8f;
        minusscore = 5;

        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }

        if (coll.gameObject.tag == "rtan")
        {
            Destroy(gameObject);
            GameManager.I.minusScore(minusscore);
        }
    }
}
