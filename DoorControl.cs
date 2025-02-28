using UnityEngine;

public class DoorControl : MonoBehaviour
{
    public GameObject[] theDoors;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.theDoors[0].SetActive(Core.northDoor);
        //MeshRenderer mr = this.theDoors[0].GetComponent<MeshRenderer>();
        //mr.enabled = false;
        this.theDoors[1].SetActive(Core.southDoor);
        //MeshRenderer mr = this.theDoors[1].GetComponent<MeshRenderer>();
        //mr.enabled = false;
        this.theDoors[2].SetActive(Core.eastDoor);
        //MeshRenderer mr = this.theDoors[2].GetComponent<MeshRenderer>();
        //mr.enabled = false;
        this.theDoors[3].SetActive(Core.westDoor);
        //MeshRenderer mr = this.theDoors[3].GetComponent<MeshRenderer>();
        //mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
