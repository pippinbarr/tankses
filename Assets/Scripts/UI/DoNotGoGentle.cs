using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DoNotGoGentle : MonoBehaviour
{

    public Light sun;
    public float lineTime = 1f;

    private string [] poem = new string[] {
"Do not go gentle into that good night,",
"Old age should burn and rave at close of day;",
"Rage, rage against the dying of the light.",
"Though wise men at their end know dark is right,",
"Because their words had forked no lightning they",
"Do not go gentle into that good night.",
"Good men, the last wave by, crying how bright",
"Their frail deeds might have danced in a green bay,",
"Rage, rage against the dying of the light.",
"Wild men who caught and sang the sun in flight,",
"And learn, too late, they grieved it on its way,",
"Do not go gentle into that good night.",
"Grave men, near death, who see with blinding sight",
"Blind eyes could blaze like meteors and be gay,",
"Rage, rage against the dying of the light."
    };
    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        StartCoroutine(DisplayPoem());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DisplayPoem() {
        for (int i = 0; i < poem.Length; i++) {
            text.text = poem[i].ToUpper();
            sun.intensity -= (1f/(poem.Length+2));
            yield return new WaitForSeconds(lineTime);
        }
    }
}
