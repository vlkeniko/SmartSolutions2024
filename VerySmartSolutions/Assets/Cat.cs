using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string name = "Paco";
    public int value = 8; 
    public string gender= "Male";
    public string owner ="Michelle"; 
    
    private float moveSpeed = 2.6f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
    
        if(Input.GetKey(KeyCode.D)) {

              Vector3 tempPos = transform.position;
	         tempPos.x += moveSpeed * Time.deltaTime;
	transform.position = tempPos;
            
        }

         if(Input.GetKey(KeyCode.A)) {

              Vector3 tempPos = transform.position;
	          tempPos.x -= moveSpeed * Time.deltaTime;
	          transform.position = tempPos;
            
        }

         if(Input.GetKey(KeyCode.W)) {

              Vector3 tempPos = transform.position;
	          tempPos.y += moveSpeed * Time.deltaTime;
	          transform.position = tempPos;
            
        }

         if(Input.GetKey(KeyCode.S)) {

              Vector3 tempPos = transform.position;
	          tempPos.y -= moveSpeed * Time.deltaTime;
	          transform.position = tempPos;
            
        }
    }
}
