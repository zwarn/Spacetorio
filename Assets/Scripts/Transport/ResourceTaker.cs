using UnityEngine;
using System.Collections;

public interface ResourceTaker {

    bool accepts(Resource resource);

    void take(Resource resource);

}
