﻿using System.Windows.Controls;

namespace ReactNative.Views.Scroll
{
    /// <summary>
    /// Extended <see cref="System.Windows.Controls.ScrollViewer"/> with partial <see cref="IScrollView"/> interface for unit testing
    /// </summary>
    public class ScrollView : ScrollViewer, IScrollView
    {
    }
}
