using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TagListType
{
    Blacklist,
    Whitelist
}

public class DestroyObject : MonoBehaviour
{
    // A class for if the tageListType is blacklist or whitelist, set to blacklist as default
    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;
    // A list of tags which we use to determine whether to destroy object or not
    // Depending on the tagListType (Blacklist or Whitelist)
    [SerializeField]
    private List<string> tags;

    // Function triggers when another object collides with the one this script is attached to
    void OnTriggerEnter2D(Collider2D other)
    {
        // Returns true if the other object is in the list of tags
        bool tagInList = tags.Contains(other.gameObject.tag);

        // If the object is a blacklist and the tag IS in the blacklist
        if (tagListType == TagListType.Blacklist 
            && tagInList)
        {
            // Then destroy the object
            Destroy(gameObject);
        }
        // If the object is a whitelist and the tag is NOT in the whitelist 
        else if (tagListType == TagListType.Whitelist 
            && !tagInList)
        {
            // Then destroy the object
            Destroy(gameObject);
        }
        // If neither of the above trigger
        else
        {
            // Then use default collision code
        }
    }

    // Function for when an object exits the viewport
    void OnBecameInvisible()
    {
        // Then destroy the object
        Destroy(gameObject);
    }
}
