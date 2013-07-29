using System.Runtime.CompilerServices;

namespace jQueryApi.UI {
    public delegate void jQueryUIEventHandler<in T>(jQueryEvent e, T uiEvent);
}
