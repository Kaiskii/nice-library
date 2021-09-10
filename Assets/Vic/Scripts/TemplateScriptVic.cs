using UnityEngine;

/**
Template of Script, Coding Conventions
*/

namespace NiceLib {
  public class TemplateScriptVic : MonoBehaviour {
    /**
      Spaces: 2
      EOL: LF
      { Same Line
    */

    string camelCase = "Coding Style";
    string single = "Example of single worded variables";
    const string TEMPLATE_CONST = "const are SCREAMING_CAPS";

    [SerializeField]
    string serialize = "Serialize instead of making it Public";

    void Start() {

    }

    void Update() {

    }

    private void PascalCase() {

    }
  }
}
