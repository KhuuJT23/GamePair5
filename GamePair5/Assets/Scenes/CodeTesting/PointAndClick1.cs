using UnityEngine;

public class PointAndClick1 : MonoBehaviour
{
    public bool mouseInput;
    public GameObject itemOpen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseInput)
        {
            itemOpen.SetActive(true);
        }
        
    }
    private void OnMouseDown()
    {
        mouseInput = true;
    }
}
