using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayFinder : MonoBehaviour {

    public Button f1;
    public Dropdown dropdownStart;
    public Dropdown dropdownFinish;
    private int sp, ep;
    private ArrayList ways;
    private bool[] visited;

    public struct Way{
        public int start;
        public int end;
        public Way(int a, int b)
        {
            start = a;
            end = b;
        }
    }

	// Use this for initialization
	void Start () {
        visited = new bool[20];
        Button btn1 = f1.GetComponent<Button>();
        btn1.onClick.AddListener(OnSearchButtonClick);

        dropdownStart.onValueChanged.AddListener(delegate {
            OnMyValueChange(dropdownStart);
        });

        dropdownFinish.onValueChanged.AddListener(delegate {
            OnYhValueChange(dropdownFinish);
        });
        ways = new ArrayList();

        ways.Add(new Way(0, 2));
        ways.Add(new Way(0, 5));
        ways.Add(new Way(0, 7));
        ways.Add(new Way(0, 8));
        ways.Add(new Way(0, 11));
        ways.Add(new Way(0, 12));
        ways.Add(new Way(0, 17));
        ways.Add(new Way(0, 18));
        ways.Add(new Way(1, 3));
        ways.Add(new Way(1, 13));
        ways.Add(new Way(1, 15));
        ways.Add(new Way(1, 16));
        ways.Add(new Way(2, 9));
        ways.Add(new Way(2, 13));
        ways.Add(new Way(3, 4));
        ways.Add(new Way(3, 13));
        ways.Add(new Way(3, 15));
        ways.Add(new Way(4, 12));
        ways.Add(new Way(5, 7));
        ways.Add(new Way(5, 12));
        ways.Add(new Way(5, 17));
        ways.Add(new Way(5, 18));
        ways.Add(new Way(6, 13));       
        ways.Add(new Way(7, 8));
        ways.Add(new Way(7, 12));
        ways.Add(new Way(7, 17));
        ways.Add(new Way(7, 18));
        ways.Add(new Way(8, 12));
        ways.Add(new Way(10, 11));
        ways.Add(new Way(10, 12));
        ways.Add(new Way(10, 13));
        ways.Add(new Way(12, 17));
        ways.Add(new Way(12, 18));
        ways.Add(new Way(13, 15));
        ways.Add(new Way(13, 16));
        ways.Add(new Way(14, 15));
        ways.Add(new Way(15, 16));
        ways.Add(new Way(17, 18));
    }

    public void OnMyValueChange(Dropdown dd)
    {
        sp = dd.value;
    }

    public void OnYhValueChange(Dropdown dd)
    {
        ep = dd.value;
    }

    // Update is called once per frame
    string SearchWay(int sp, int ep, string curWay)
    {
        visited[sp] = true;
        if ((ways.Contains(new Way(sp,ep)))||(ways.Contains(new Way(ep,sp))))
        {
            Debug.Log(curWay + "Зашло");
            return Convert.ToString(ep);
        }
        else
        {
            foreach (Way i in ways)
            {
                if ((i.start == sp)&&(!visited[i.end]))
                {
                    Debug.Log(curWay + "Зашло");
                    return Convert.ToString(sp) + SearchWay(i.end, ep, curWay);
                    
                }
                if ((i.end == sp) && (!visited[i.end]))
                {
                    Debug.Log(curWay + "Зашло");
                    return Convert.ToString(sp) + SearchWay(i.start, ep, curWay);
                    
                }
            }
        }
        visited[sp] = false;
        return curWay;
    }

    void OnSearchButtonClick ()
    {
        Debug.Log(SearchWay(sp, ep, ""));
	}
}
