// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Toolkit.Win32.UI.XamlHost
{
    /// <summary>
    /// Enables access to native methods on DesktopWindowXamlSourceNative
    /// </summary>
    /// <remarks>
    /// Includes the method used to set the window handle of the <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> instance.
    /// </remarks>
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("3cbcf1bf-2f76-4e9c-96ab-e84b37972554")]
    partial interface IDesktopWindowXamlSourceNative
    {
        /// <summary>
        /// Attaches the <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> to a window using a window handle.
        /// </summary>
        /// <param name="parentWnd">pointer to parent Wnd</param>
        /// <remarks>
        /// The associated window will be used to parent UWP XAML visuals, appearing
        /// as UWP XAML's logical render target.
        /// </remarks>
        void AttachToWindow(IntPtr parentWnd);

        /// <summary>
        /// Gets the handle associated with the <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> instance.
        /// </summary>
        IntPtr WindowHandle { get; }
    }

    /// <summary>
    /// Enables access to native methods on DesktopWindowXamlSourceNative version 2 for RS5
    /// </summary>
    /// <remarks>
    /// Includes the method used to set the window handle of the <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> instance.
    /// </remarks>
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("e3dcd8c7-3057-4692-99c3-7b7720afda31")]
    partial interface IDesktopWindowXamlSourceNative2
    {
        /// <summary>
        /// Attaches the <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> to a window using a window handle.
        /// </summary>
        /// <param name="parentWnd">pointer to parent Wnd</param>
        /// <remarks>
        /// The associated window will be used to parent UWP XAML visuals, appearing
        /// as UWP XAML's logical render target.
        /// </remarks>
        void AttachToWindow(IntPtr parentWnd);

        /// <summary>
        /// Gets the handle associated with the <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> instance.
        /// </summary>
        IntPtr WindowHandle { get; }

        /// <summary>
        /// Sends the <paramref name="message"/> to the internal <see cref="Windows.UI.Xaml.Hosting.DesktopWindowXamlSource" /> window handle.
        /// </summary>
        /// <returns>True if the <paramref name="message"/> was handled</returns>
        bool PreTranslateMessage(ref System.Windows.Interop.MSG message);
    }
}
