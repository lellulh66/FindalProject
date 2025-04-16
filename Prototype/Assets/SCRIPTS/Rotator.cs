
using UnityEngine;
using UnityEngine.UIElements;


public class Rotator : MonoBehaviour
{
    /*use for overhead tokens when buttons are triggered*/
    public float speed = 45;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up,speed * Time.deltaTime); 
        
    }
}
