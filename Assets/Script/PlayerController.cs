using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting.APIUpdating;

public class PLayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float maxY, minY;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0);
        }

        if (transform.position.y > maxY || transform.position.y < minY)
        {
            Debug.Log("out of bound");
            DeathController.Instance.Death();
        }
    }

    private void OnCollisionEnter(Collision collision)

    {

    }
    private void OnCollisionExit(Collision collision)
    {



    }
}

