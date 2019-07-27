using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalizationWaiter : MonoBehaviour {

    private IEnumerator Start() {
        Item a = new Item();
        
        LocalizationManager.instance.LoadLocalizedText("en_us.json");

        yield return new WaitUntil(() => LocalizationManager.instance.isReady);

        SceneManager.LoadScene("Tutorial");
    }
}
