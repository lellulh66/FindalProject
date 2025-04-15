using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPosition;
    public TMP_Text healthText;
    public EndScreenAnim gameOverScreen;
     public void Start()
    {
        respawnPosition = transform.position;

    } 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);
        }
        if (other.CompareTag("Fireball"))
        {
            Damage(2);
        }
        if (other.CompareTag("Checkpoint"))
        {
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;
            Destroy(other.gameObject);
        }

    }



    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"<b>Health: </b>{points}";
        // text.text confirms the string type
        if (points < 1)
        {
            gameOverScreen.StartFade();
            //Destroy(gameObject);
            transform.position = respawnPosition;
            points = 5;

        }
    }
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
 

