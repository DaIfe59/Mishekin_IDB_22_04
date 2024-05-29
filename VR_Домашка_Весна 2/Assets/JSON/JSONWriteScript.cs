using System.IO;
using UnityEngine;

public class JSONWriteScript : MonoBehaviour
{

    [System.Serializable]

    public class stanok
    {
        public string stanok_name;
    }

    [System.Serializable]

    public class stanokList
    {
        public stanok[] stanok;
    }

    public stanok myStanok = new stanok();
    public stanokList stanoklist = new stanokList();

    public void outputJSON()
    {
        string strOutput = JsonUtility.ToJson(myStanok);

        File.WriteAllText(Application.dataPath + "/text.txt", strOutput);

        string strOutput2 = JsonUtility.ToJson(stanoklist);

        File.WriteAllText(Application.dataPath + "/text2.txt", strOutput2);
    }


}
