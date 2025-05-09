﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace Blazonia.Core;

/// <summary>
/// Defines a mechanism for an <see cref="IElementHandler"/> to accept inline text.
/// </summary>
public interface IHandleChildContentText
{
    /// <summary>
    /// This method is called to process inline text found in a component.
    /// </summary>
    /// <param name="isAdd">If text should be added or replaced</param>
    /// <param name="index">the index of the string within a group of text strings.</param>
    /// <param name="text">The text to handle. This text may contain whitespace at the start and end of the string.</param>
    void HandleText(bool isAdd, int index, string text);
}
