using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool mouseInRange;
    public GameObject itemInteract;
    public GameObject itemOpen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            itemOpen.SetActive(true);

        }


        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("InteractionObject"))
        {
            mouseInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("InteractionObject"))
        {
            mouseInRange = false;
        }

    }
}
