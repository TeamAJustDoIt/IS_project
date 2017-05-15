using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeFloor : MonoBehaviour {

    public GameObject floor1;
    public GameObject floor2;
    public GameObject floor3;
    public Button f1;
    public Button f2;
    public Button f3;

    private Vector3 back = new Vector3(0, 0, 11);
    private Vector3 main = new Vector3(0, 0, 10);

    // Use this for initialization
    void Start()
    {
        Button btn1 = f1.GetComponent<Button>();
        btn1.onClick.AddListener(OnClickFirstFloor);

        Button btn2 = f2.GetComponent<Button>();
        btn2.onClick.AddListener(OnClickSecondFloor);

        Button btn3 = f3.GetComponent<Button>();
        btn3.onClick.AddListener(OnClickThirdFloor);
    }

    void OnClickFirstFloor()
    {
        floor1.transform.position = main;
        floor2.transform.position = back;
        floor3.transform.position = back;

        Debug.Log("You have clicked 1st floor button!");
    }

    void OnClickSecondFloor()
    {
        floor1.transform.position = back;
        floor2.transform.position = main;
        floor3.transform.position = back;

        Debug.Log("You have clicked 2nd floor button!");
    }

    void OnClickThirdFloor()
    {
        floor1.transform.position = back;
        floor2.transform.position = back;
        floor3.transform.position = main;

        Debug.Log("You have clicked 3rd floor button!");
    }
    // Update is called once per frame
}
