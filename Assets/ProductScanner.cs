using UnityEngine;
using TMPro;

public class ProductScanner : MonoBehaviour
{
    public TMP_Text productName;
    public TMP_Text price;
    public TMP_Text description;

    public void OpenCamera()
    {
        NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                DetectProduct(path);
            }
        });
    }

    void DetectProduct(string path)
    {
        path = path.ToLower();

        if (path.Contains("mobile"))
        {
            productName.text = "Mobile Phone";
            price.text = "₹15000";
            description.text = "Android smartphone";
        }
        else if (path.Contains("laptop"))
        {
            productName.text = "Laptop";
            price.text = "₹55000";
            description.text = "High performance laptop";
        }
        else if (path.Contains("headphone"))
        {
            productName.text = "Headphones";
            price.text = "₹2000";
            description.text = "Wireless headphones";
        }
        else if (path.Contains("tv"))
        {
            productName.text = "Television";
            price.text = "₹30000";
            description.text = "Smart LED TV";
        }
        else if (path.Contains("camera"))
        {
            productName.text = "Camera";
            price.text = "₹25000";
            description.text = "Digital camera";
        }
        else if (path.Contains("mouse"))
        {
            productName.text = "Mouse";
            price.text = "₹500";
            description.text = "Wireless mouse";
        }
        else if (path.Contains("keyboard"))
        {
            productName.text = "Keyboard";
            price.text = "₹1500";
            description.text = "Mechanical keyboard";
        }
        else if (path.Contains("speaker"))
        {
            productName.text = "Speaker";
            price.text = "₹3000";
            description.text = "Bluetooth speaker";
        }
        else if (path.Contains("watch") || path.Contains("smartwatch"))
        {
            productName.text = "Smartwatch";
            price.text = "₹4000";
            description.text = "Fitness smartwatch";
        }
        else if (path.Contains("charger"))
        {
            productName.text = "Charger";
            price.text = "₹800";
            description.text = "Fast charger";
        }
        else
        {
            productName.text = "Unknown Product";
            price.text = "-";
            description.text = "Not recognized";
        }
    }
}