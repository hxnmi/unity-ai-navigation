using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    Vector3 goal;
    float speed = 1.0f;
    float accuracy = 1.0f;

    private void Start()
    {
        goal = this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            goal = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
        }
        this.transform.LookAt(goal);
        if (Vector3.Distance(transform.position, goal) > accuracy)
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }

    }
}

