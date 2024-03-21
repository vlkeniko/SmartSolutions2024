using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed = 12f;
    public float moveSpeed = 5f;

    private Rigidbody2D myRigidbody;

    [Header("-- Private references --")]
    [SerializeField] private int coinsCollected = 0;
    [SerializeField] private GameObject winningFlag;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Jump
        if(Input.GetKeyDown(KeyCode.Space)) {
            Vector2 newSpeed = myRigidbody.velocity;
            newSpeed.y = jumpSpeed;
            myRigidbody.velocity = newSpeed; 
        }

        // ------------------------------------------------------
        //   -- Create your own code for moving to the sides --
        // ------------------------------------------------------
        // Hint: Must use if-statements, Input.GetKey(), transform.position & Time.deltaTime
        
        Vector3 newPosition = transform.position;
            if(Input.GetKey(KeyCode.A)) {
                newPosition.x -= moveSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.D)) {
                newPosition.x += moveSpeed * Time.deltaTime;
            }
        transform.position = newPosition;
    }

    // OnTriggerEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
        // - One of the Collider2Ds must be a Trigger
    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Coin")) {
            coinsCollected += 1;
            Destroy(coll.gameObject);
        }

        if(coinsCollected == 3) {
            Instantiate(winningFlag);
        }
    }

    // OnCollisionEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
    void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag.Equals("Finish")) {
            print("You have won the game!");
        }
    }
}
