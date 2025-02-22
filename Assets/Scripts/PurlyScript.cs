using UnityEngine;

public class PurlyScript : MonoBehaviour
{

    //move speed
    public float moveSpeed = 5.0f;

    // rotation speed
    public float rotationSpeed = 100.0f; //speed for rotation

    //variables translation and rotation
    public float translation = 0, rotation = 0;


    void Start()
    {
        Debug.Log("We are in the start function");
    }

    // Update is called once per frame
    void Update()
    {
    //initialize with deltaTime
        rotation = rotationSpeed * Time.deltaTime;

        translation = moveSpeed * Time.deltaTime;

        // Moving left side
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * translation, Space.World);
        }


        // Moving right side
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * translation, Space.World);
        }


        // Moving up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * translation, Space.World);
        }


        // Moving down
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * translation, Space.World);
        }

        // Rotation around Y-axis (Q and E keys)
        float roationIn = 0f;
        if (Input.GetKey(KeyCode.Q))
        {
            roationIn = -1f;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            roationIn = 1f;
        }
        transform.Rotate(0f, roationIn * rotationSpeed * Time.deltaTime, 0f, Space.World);
    }


}

