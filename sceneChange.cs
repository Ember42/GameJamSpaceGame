using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update

    public void gameStart()
    {
        Application.LoadLevel("mainScene");
    }
}
