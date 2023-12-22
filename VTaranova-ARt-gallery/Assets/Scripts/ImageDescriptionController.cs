using UnityEngine;
using TMPro;
public class ImageDescriptionController : MonoBehaviour
{
    public TextMeshPro descriptionText;
    public int imageIndex;
    private string[] imageDescriptions = {
        "Where: Louvre Museum, Paris, France. Style: Italian Renaissance, sfumato, chiaroscuro. Note: Enigmatic smile, subject's mystery.",
        "Where: Santa Maria delle Grazie, Milan, Italy. Style: High Renaissance, innovative composition. Note: Depicts Jesus' betrayal announcement.",
        "Where: Museum of Modern Art, NYC, USA. Style: Post-impressionism, vibrant colors. Note: Reflects Van Gogh's emotional state.",
        "Where: National Gallery, Oslo, Norway. Style: Expressionism, distorted figure. Note: Conveys existential dread.",
        "Where: Museo Reina Sofia, Madrid, Spain. Style: Cubism, fragmented forms. Note: Picasso's anti-war statement."
    };
    void Start()
    {
        if (imageIndex >= 0 && imageIndex <= imageDescriptions.Length)
        {
            descriptionText.text = imageDescriptions[imageIndex];
        }
        else
        {
            Debug.LogError("Invalid index for button");
        }
    }
    public void OnButtonClick()
    {
        if (imageIndex >= 0 && imageIndex < imageDescriptions.Length)
        {
            descriptionText.text = imageDescriptions[imageIndex];
        }
        else
        {
            Debug.LogError("Invalid index for button");
        }
    }
}