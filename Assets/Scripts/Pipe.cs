using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

    private Character character;

    // Use this for initialization
    void Start()
    {
        character = FindObjectOfType<Character>();
    }


    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 60)
        {
            void Update()
            {
                if (character.transform.position.x - transform.position.x > 60)
                {

                    float xRan = Random.Range(0, 40);
                    float yRan = Random.Range(-25, 6);

                    Instantiate(gameObject, new Vector2(character.transform.position.x + 35 + xRan, -20 + yRan), transform.rotation);
                    Destroy(gameObject);

                }

            }

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            character.Death();
        }
    }

}


