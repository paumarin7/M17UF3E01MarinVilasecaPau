using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{

    public GameObject gm;
    [SerializeField]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y- gm.GetComponent<GameManager>().speed, transform.position.z); 
    }
}
