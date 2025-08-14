using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float walk;
    public GameObject birdPrefab;
    public Transform shootPoint;
    public float shootForce;
    public bool cameraOff;
    public GameObject camera;
    public float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            launchBird();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-walk * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(walk * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, walk * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -walk * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-rotSpeed * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
        }
    }
    void launchBird()
    {
        GameObject tempBird = Instantiate(birdPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody tempRb = tempBird.GetComponent<Rigidbody>();
        tempRb.AddForce(tempBird.transform.forward * shootForce, ForceMode.Impulse);
        Destroy(tempBird, 3f);
        DisableCamera();


    }
    IEnumerator DisableCamera()
    {
        cameraOff = true;
        camera.SetActive(false);
        yield return new WaitForSeconds(3f);
        cameraOff = false;
        camera.SetActive(true);



    }

}
