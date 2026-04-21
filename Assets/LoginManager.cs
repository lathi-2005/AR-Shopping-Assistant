using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Collections;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public TextMeshProUGUI messageText;

    string loginURL = "http://localhost/ar_app/login.php";

    public void LoginUser()
    {
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", emailInput.text);
        form.AddField("password", passwordInput.text);

        UnityWebRequest www = UnityWebRequest.Post(loginURL, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            if (www.downloadHandler.text == "success")
            {
                messageText.text = "Login Successful!";
                UnityEngine.SceneManagement.SceneManager.LoadScene("ScanScene");
            }
            else
            {
                messageText.text = "Invalid Credentials!";
            }
        }
        else
        {
            messageText.text = "Error connecting server!";
        }
    }
}