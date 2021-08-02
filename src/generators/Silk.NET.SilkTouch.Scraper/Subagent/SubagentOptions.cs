﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using ClangSharp;

namespace Silk.NET.SilkTouch.Scraper.Subagent
{
    /// <summary>
    /// Encapsulates ClangSharp options in a serializable record.
    /// </summary>
    /// <remarks>
    /// The only reason this exists is because <see cref="PInvokeGeneratorConfiguration"/> doesn't play nicely with JSON
    /// serialization, and we use JSON serialization to communicate the options to the subprocesses.
    /// </remarks>
    /// <param name="LibraryPath">
    /// The <see cref="PInvokeGeneratorConfiguration.LibraryPath"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="NamespaceName">
    /// The <see cref="PInvokeGeneratorConfiguration.Namespace"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="OutputLocation">
    /// The <see cref="PInvokeGeneratorConfiguration.OutputLocation"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="TestOutputLocation">
    /// The <see cref="PInvokeGeneratorConfiguration.TestOutputLocation"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="OutputMode">
    /// The <see cref="PInvokeGeneratorConfiguration.OutputMode"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="Options">
    /// The <see cref="PInvokeGeneratorConfigurationOptions"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="ExcludedNames">
    /// The <see cref="PInvokeGeneratorConfiguration.ExcludedNames"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="HeaderFile">
    /// The file containing the <see cref="PInvokeGeneratorConfiguration.HeaderText"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="MethodClassName">
    /// The <see cref="PInvokeGeneratorConfiguration.MethodClassName"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="MethodPrefixToStrip">
    /// The <see cref="PInvokeGeneratorConfiguration.MethodPrefixToStrip"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="RemappedNames">
    /// The <see cref="PInvokeGeneratorConfiguration.RemappedNames"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="TraversalNames">
    /// The <see cref="PInvokeGeneratorConfiguration.TraversalNames"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="WithAttributes">
    /// The <see cref="PInvokeGeneratorConfiguration.WithAttributes"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="WithCallConvs">
    /// The <see cref="PInvokeGeneratorConfiguration.WithCallConvs"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="WithLibraryPaths">
    /// The <see cref="PInvokeGeneratorConfiguration.WithLibraryPaths"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="WithSetLastErrors">
    /// The <see cref="PInvokeGeneratorConfiguration.WithSetLastErrors"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="WithTypes">
    /// The <see cref="PInvokeGeneratorConfiguration.WithTypes"/> for ClangSharp to use in XML generation.
    /// </param>
    /// <param name="WithUsings">
    /// The <see cref="PInvokeGeneratorConfiguration.WithUsings"/> for ClangSharp to use in XML generation.
    /// </param>
    public record SubagentOptions
    (
        string LibraryPath,
        string NamespaceName,
        string OutputLocation,
        string TestOutputLocation,
        string[] IncludeDirectories,
        PInvokeGeneratorOutputMode OutputMode = PInvokeGeneratorOutputMode.CSharp,
        PInvokeGeneratorConfigurationOptions Options = PInvokeGeneratorConfigurationOptions.None,
        string Language = "c++",
        string Standard = "c++17",
        string[]? AdditionalArgs = null,
        string[]? DefineMacros = null,
        string[]? ExcludedNames = null,
        string? HeaderFile = null,
        string? MethodClassName = null,
        string? MethodPrefixToStrip = null,
        IReadOnlyDictionary<string, string>? RemappedNames = null,
        string[]? TraversalNames = null,
        IReadOnlyDictionary<string, IReadOnlyList<string>>? WithAttributes = null,
        IReadOnlyDictionary<string, string>? WithCallConvs = null,
        IReadOnlyDictionary<string, string>? WithLibraryPaths = null,
        string[]? WithSetLastErrors = null,
        IReadOnlyDictionary<string, string>? WithTypes = null,
        IReadOnlyDictionary<string, IReadOnlyList<string>>? WithUsings = null
    )
    {
        /// <summary>
        /// Converts the given <see cref="SubagentOptions"/> to a ClangSharp-consumable
        /// <see cref="PInvokeGeneratorConfiguration"/>.
        /// </summary>
        /// <param name="opts">The options to convert.</param>
        /// <returns>The converted options.</returns>
        public static implicit operator PInvokeGeneratorConfiguration(SubagentOptions opts) => new
        (
            opts.LibraryPath,
            opts.NamespaceName,
            opts.OutputLocation,
            opts.TestOutputLocation,
            opts.OutputMode,
            opts.Options,
            opts.ExcludedNames,
            opts.HeaderFile,
            opts.MethodClassName,
            opts.MethodPrefixToStrip,
            opts.RemappedNames,
            opts.TraversalNames,
            opts.WithAttributes,
            opts.WithCallConvs,
            opts.WithLibraryPaths,
            opts.WithSetLastErrors,
            opts.WithTypes,
            opts.WithUsings
        );
    }
}