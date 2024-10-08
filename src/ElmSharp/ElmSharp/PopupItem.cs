/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace ElmSharp
{
    /// <summary>
    /// The PopupItem is a class that includes the icon and text.
    /// </summary>
    /// <since_tizen> preview </since_tizen>
    [Obsolete("This has been deprecated in API12")]
    public class PopupItem : ItemObject
    {
        internal PopupItem(string text, EvasObject icon) : base(IntPtr.Zero)
        {
            Text = text;
            Icon = icon;
        }

        internal PopupItem(string text, EvasObject icon, EvasObject parent) : base(IntPtr.Zero, parent)
        {
            Text = text;
            Icon = icon;
        }

        /// <summary>
        /// Gets the text label of the popupitem. Return value is string.
        /// </summary>
        /// <since_tizen> preview </since_tizen>
        [Obsolete("This has been deprecated in API12")]
        public string Text { get; internal set; }

        /// <summary>
        /// Gets the EvasObject icon of the popupitem.
        /// </summary>
        /// <since_tizen> preview </since_tizen>
        [Obsolete("This has been deprecated in API12")]
        public EvasObject Icon { get; internal set; }
    }
}
