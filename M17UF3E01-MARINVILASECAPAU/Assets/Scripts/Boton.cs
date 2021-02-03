using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{

    public Material bien;
    public Material mal;
    public Material normal;

    [SerializeField]
    public GameObject gm;
    [SerializeField]
    public bool dentro = false;
    public bool quitarPuntos = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    void Update()
    {
        
        if (!dentro)
        {
            if (quitarPuntos)
            {

                if (Input.GetKey("z") && this.gameObject.name == "boton")
                {

                    quitarPuntos = false;
                    gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().fallo, 1f);
                    gm.GetComponent<GameManager>().puntos--;
                    StartCoroutine(cambiarColor(1, "boton"));
                }
                if (Input.GetKey("x") && this.gameObject.name == "boton1")
                {
                    quitarPuntos = false;
                    gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().fallo, 1f);
                    gm.GetComponent<GameManager>().puntos--;
                    StartCoroutine(cambiarColor(1, "boton1"));

                }
                if (Input.GetKey("c") && this.gameObject.name == "boton2")
                {
                    quitarPuntos = false;
                    gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().fallo, 1f);
                    gm.GetComponent<GameManager>().puntos--;
                    StartCoroutine(cambiarColor(1, "boton2"));

                }
                if (Input.GetKey("v") && this.gameObject.name == "boton3")
                {
                    quitarPuntos = false;
                    gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().fallo, 1f);
                    gm.GetComponent<GameManager>().puntos++;
                    StartCoroutine(cambiarColor(1, "boton3"));
                }
            }
           
        }

    }



    private void OnTriggerStay(Collider other)
    {
        dentro = true;
        if (dentro)
        {
            if (Input.GetKey("z") && this.gameObject.name == "boton")
            {
                dentro = true;
                gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().bien, 1f);
                gm.GetComponent<GameManager>().puntos++;
                StartCoroutine(cambiarColor(0, "boton"));
                Destroy(other.gameObject);
            }
            if (Input.GetKey("x") && this.gameObject.name == "boton1")
            {
                dentro = true;
                gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().bien, 1f);
                gm.GetComponent<GameManager>().puntos++;
                Destroy(other.gameObject);
                StartCoroutine(cambiarColor(0, "boton1"));
            }
            if (Input.GetKey("c") && this.gameObject.name == "boton2")
            {
                dentro = true;
                gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().bien, 1f);
                gm.GetComponent<GameManager>().puntos++;
                StartCoroutine(cambiarColor(0, "boton2"));
                Destroy(other.gameObject);
            }
            if (Input.GetKey("v") && this.gameObject.name == "boton3")
            {
                dentro = true;
                gm.GetComponent<GameManager>().sonidoj.PlayOneShot(gm.GetComponent<GameManager>().bien, 1f);
                gm.GetComponent<GameManager>().puntos++;
                Destroy(other.gameObject);
                StartCoroutine(cambiarColor(0, "boton3"));
            }
        }

    }

    public IEnumerator cambiarColor(int i, string s)
    {
        if (this.gameObject.name == s)
        {
            if(i == 0)
            {
                this.gameObject.GetComponent<Renderer>().material.color = bien.color;
            }
            else
            {
                this.gameObject.GetComponent<Renderer>().material.color = mal.color;
            }

        }
        if (this.gameObject.name == s)
        {
            if (i == 0)
            {
                this.gameObject.GetComponent<Renderer>().material.color = bien.color;
            }
            else
            {
                this.gameObject.GetComponent<Renderer>().material.color = mal.color;
            }
        }
        if (this.gameObject.name == s)
        {
            if (i == 0)
            {
                this.gameObject.GetComponent<Renderer>().material.color = bien.color;
            }
            else
            {
                this.gameObject.GetComponent<Renderer>().material.color = mal.color;
            }
        }
        if (this.gameObject.name == s)
        {
            if (i == 0)
            {
                this.gameObject.GetComponent<Renderer>().material.color = bien.color;
            }
            else
            {
                this.gameObject.GetComponent<Renderer>().material.color = mal.color;
            }
        }
        yield return new WaitForSeconds(0.4f);
        if (this.gameObject.name == s)
        {
            this.gameObject.GetComponent<Renderer>().material.color = normal.color;

        }
        if (this.gameObject.name == s)
        {
            this.gameObject.GetComponent<Renderer>().material.color = normal.color;
        }
        if (this.gameObject.name == s)
        {
            this.gameObject.GetComponent<Renderer>().material.color = normal.color;

        }
        if (this.gameObject.name == s)
        {
            this.gameObject.GetComponent<Renderer>().material.color = normal.color;

        }
        dentro = false;
        quitarPuntos = true;

    }
}
