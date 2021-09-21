using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
    {

        [SerializeField] private float turnSpeed = 10;
        
        // Start is called before the first frame update
        void Start()
        {
            
        }
    
        // Update is called once per frame
        void FixedUpdate()
        {
            float camRot = Camera.main.transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(0,camRot,0), turnSpeed*Time.deltaTime);
        }
        
    }