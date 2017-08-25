using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehavior : MonoBehaviour {

	[System.Serializable]
	public class Entry{

		public int value; 
		public string key; 
	}

	public List<Entry> entrylist = new List<Entry>();

	void Reset(){
		
		entrylist.Add (new Entry { value = 20, key = "matar"});
		entrylist.Add (new Entry { value = 70, key = "denovo" });
		entrylist.Add (new Entry { value = 100, key = "morrer" });
	}
}
