using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 2;
    private Vector3 offset;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = target.position - transform.position ;

    }

    // Update is called once per frame
    void Update()
    {
        //check if player exists 
        if (target == null)
        { 
            enabled = false;
            return;
        }
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, transitionSpeed * Time.deltaTime);

            
    }
}
