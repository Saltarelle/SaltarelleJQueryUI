using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class PositionOptions {

        /// <summary>
        /// Defines which position <strong>on the target element</strong> to align the positioned element against: "horizontal vertical" alignment. See the <a href="#option-my"><code>my</code></a> option for full details on possible values. Perecentage offsets are relative to the target element.
        /// </summary>
        public string At {
            get; set;
        }

        /// <summary>
        /// <para>When the positioned element overflows the window in some direction, move it to an alternative position. Similar to <a href="#option-my"><code>my</code></a> and <a href="#option-at"><code>at</code></a>, this accepts a single value or a pair for horizontal/vertical, e.g., <code>"flip"</code>, <code>"fit"</code>, <code>"fit flip"</code>, <code>"fit none"</code>.</para><ul><li><code>"flip"</code>: Flips the element to the opposite side of the target and the collision detection is run again to see if it will fit. Whichever side allows more of the element to be visible will be used.</li><li><code>"fit"</code>: Shift the element away from the edge of the window.</li><li><code>"flipfit"</code>: First applies the flip logic, placing the element on whichever side allows more of the element to be visible. Then the fit logic is applied to ensure as much of the element is visible as possible.</li><li><code>"none"</code>: Does not apply any collision detection.</li></ul>
        /// </summary>
        public string Collision {
            get; set;
        }

        /// <summary>
        /// Defines which position <strong>on the element being positioned</strong> to align with the target element: "horizontal vertical" alignment. A single value such as <code>"right"</code> will be normalized to <code>"right center"</code>, <code>"top"</code> will be normalized to <code>"center top"</code> (following CSS convention). Acceptable horizontal values: <code>"left"</code>, <code>"center"</code>, <code>"right"</code>. Acceptable vertical values: <code>"top"</code>, <code>"center"</code>, <code>"bottom"</code>. Example: <code>"left top"</code> or <code>"center center"</code>. Each dimension can also contain offsets, in pixels or percent, e.g., <code>"right+10 top-25%"</code>. Percentage offsets are relative to the element being positioned.
        /// </summary>
        public string My {
            get; set;
        }

        /// <summary>
        /// Which element to position against. If you provide a selector or jQuery object, the first matching element will be used. If you provide an event object, the <code>pageX</code> and <code>pageY</code> properties will be used. Example: <code>"#top-menu"</code>
        /// </summary>
        public TypeOption<Element, jQueryEvent, jQueryObject, string> Of {
            get; set;
        }

        /// <summary>
        /// When specified, the actual property setting is delegated to this callback. Receives two parameters: The first is a hash of <code>top</code> and <code>left</code> values for the position that should be set and can be forwarded to <code>.css()</code> or <code>.animate()</code>.<para>The second provides feedback about the position and dimensions of both elements, as well as calculations to their relative position. Both <code>target</code> and <code>element</code> have these properties: <code>element</code>, <code>left</code>, <code>top</code>, <code>width</code>, <code>height</code>. In addition, there's <code>horizontal</code>, <code>vertical</code> and <code>important</code>, giving you twelve potential directions like <code>{ horizontal: "center", vertical: "left", important: "horizontal" }</code>.</para>
        /// </summary>
        public Delegate Using {
            get; set;
        }

        /// <summary>
        /// Element to position within, affecting collision detection. If you provide a selector or jQuery object, the first matching element will be used.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> Within {
            get; set;
        }
    }
}
