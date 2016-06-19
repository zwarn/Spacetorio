using UnityEngine;
using System.Collections;

public interface ResourceTaker {

    bool Accepts(Resource resource);

    void Take(Resource resource);

}
