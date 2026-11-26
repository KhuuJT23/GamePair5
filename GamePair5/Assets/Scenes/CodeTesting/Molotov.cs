using UnityEngine;

public class Molotov : MonoBehaviour
{
    public int count = 0;
    public int max = 100;
   
    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;
    
    public bool playerBad;
    public bool playerGood;
    public bool playerAmazing;
    public bool mouseInput;
   
    public float speed;
    public Transform[] waypoint;
    public int current = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform point = waypoint[current];
        if(mouseInput && playerBad)
        {
            count += 5;
        }else if(mouseInput && playerGood)
        {
            count += 10;
        }
        else if(mouseInput && playerGood)
        {
            count += 20;
        }
        
       while(count < 50)
       {
        phase1.SetActive(true);
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, point.position) < 0.1f)
        {
            current = (current + 1) % waypoint.Length;
        }
       }
       while(50 < count || count < max)
       {
        phase2.SetActive(true);
        transform.position = Vector2.MoveTowards(transform.position, point.position, (speed *2) * Time.deltaTime);
          if(Vector2.Distance(transform.position, point.position) < 0.1f)
        {
            current = (current + 1) % waypoint.Length;
        }

       }
        while(count == max)
        {
            phase3.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collsion)
    {
        if(collsion.CompareTag("BadMolotov"))
        {
            playerBad = true;
        }else if(collsion.CompareTag("GoodMolotov"))
        {
            playerGood = true;
        }else if(collsion.CompareTag("AmazingMolotov"))
        {
            playerAmazing = true;

        }

    }
    private void OnMouseDown()
    {
        mouseInput = true;
    }
   /* private void OnTriggerExit2D(Collider2D collison)
    {
        if(collision.CompareTag("BadMolotov"))
        {
            playerBad = true;
        }
    }
    */

}
