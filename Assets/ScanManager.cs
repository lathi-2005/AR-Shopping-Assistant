using UnityEngine;
using TMPro;
using System.Collections;

public class ScanManager : MonoBehaviour
{
    public TMP_Text productName;
    public TMP_Text price;
    public TMP_Text description;

    public void OnScanClick()
    {
        StartCoroutine(GetProduct());
    }

    IEnumerator GetProduct()
    {
        string url = "http://localhost/ar_app/get_product.php?code=123";

        WWW www = new WWW(url);
        yield return www;

        Product p = JsonUtility.FromJson<Product>(www.text);

        productName.text = p.name;
        price.text = p.price;
        description.text = p.description;
    }
}

[System.Serializable]
public class Product
{
    public string name;
    public string price;
    public string description;
}