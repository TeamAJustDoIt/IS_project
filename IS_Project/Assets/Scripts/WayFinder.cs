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
	private ArrayList curway;
    private bool[] visited;
	public ArrayList neededWay;
	public bool found = false;
	public GameObject startImage;

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
		curway = new ArrayList();
		neededWay = new ArrayList ();

        ways.Add(new Way(0, 2));
		ways.Add(new Way(0, 5));
		ways.Add(new Way(0, 7));
		ways.Add(new Way(0, 11));
		ways.Add(new Way(0, 12));
		ways.Add(new Way(0, 17));
		ways.Add(new Way(1, 3));
		ways.Add(new Way(1, 15));
		ways.Add(new Way(1, 16));
		ways.Add(new Way(2, 9));
		ways.Add(new Way(2, 13));
		ways.Add(new Way(4, 10));
		ways.Add(new Way(4, 12));
		ways.Add(new Way(5, 7));
		ways.Add(new Way(5, 12));
		ways.Add(new Way(5, 17));
		ways.Add(new Way(6, 13));
		ways.Add(new Way(7, 8));
		ways.Add(new Way(7, 12));
		ways.Add(new Way(7, 17));
		ways.Add(new Way(7, 18));
		ways.Add(new Way(10, 11));
		ways.Add(new Way(10, 13));
		ways.Add(new Way(11, 12));
		ways.Add(new Way(12, 17));
		ways.Add(new Way(13, 15));
		ways.Add(new Way(13, 16));
		ways.Add(new Way(14, 15));
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
	void SearchWay(int sp, int ep, ArrayList curWay)
    {

		if (found)
			return;
		
		foreach (Way way in ways) {
			if (((way.start == sp) && (way.end == ep)) || ((way.end == sp) && (way.start == ep))) {
				curWay.Add (ep);
				foreach (int i in curWay) {
					neededWay.Add (i);
				}
				found = true;
				return;
			}
			if ((way.start == sp)&&(!visited[way.end])&&(!found)) {
				visited [way.end] = true;
				curWay.Add (way.end);
				SearchWay (way.end, ep, curWay);
				curWay.RemoveAt (curWay.Count - 1);
				visited [way.end] = false;
			}
			else if ((way.end == sp)&&(!visited[way.start])&&(!found)) {
				visited [way.start] = true;
				curWay.Add (way.start);
				SearchWay (way.start, ep, curWay);
				curWay.RemoveAt (curWay.Count - 1);
				visited [way.start] = false;
			}
		}
		;
    }

	void OnSearchButtonClick ()
    {
		curway.Clear();
		neededWay.Clear ();
		curway.Add(sp);
		for (int i = 0; i < 20; i++) {
			visited [i] = false;
		}
		visited [sp] = true;
		SearchWay (sp, ep, curway);
		visited [sp] = false;
		int a = Convert.ToInt32(neededWay[0]);
		GetComponent<DrawPoint> ().currPlace = 0;
		GetComponent<DrawPoint>().chooseRoom (a, startImage);
		found = false;
	}
}
