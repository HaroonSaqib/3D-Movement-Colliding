using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScript : MonoBehaviour
{
    //[SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0;
    //[SerializeField] float zValue = 0;
    [SerializeField] float movespeed = 5000f;
    public Rigidbody rb;

    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        
        hits++;
        Debug.Log("Bump into the wall");
        Debug.Log("You Bumped into the wall " + hits + " times");
       
        
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Vertical")*Time.deltaTime * movespeed, yValue, Input.GetAxis("Horizontal")*Time.deltaTime * movespeed);
        rb.transform.Rotate(1, 1, 1);
    }
}
