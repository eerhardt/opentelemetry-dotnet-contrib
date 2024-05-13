// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from scripts/templates/SemanticConventionsAttributes.cs.j2</auto-generated>

#pragma warning disable CS1570 // XML comment has badly formed XML

using System;

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class GraphqlAttributes
{
    /// <summary>
    /// The GraphQL document being executed.
    /// </summary>
    /// <remarks>
    /// The value may be sanitized to exclude sensitive information.
    /// </remarks>
    public const string AttributeGraphqlDocument = "graphql.document";

    /// <summary>
    /// The name of the operation being executed.
    /// </summary>
    public const string AttributeGraphqlOperationName = "graphql.operation.name";

    /// <summary>
    /// The type of the operation being executed.
    /// </summary>
    public const string AttributeGraphqlOperationType = "graphql.operation.type";

    /// <summary>
    /// The type of the operation being executed.
    /// </summary>
    public static class GraphqlOperationTypeValues
    {
        /// <summary>
        /// GraphQL query.
        /// </summary>
        public const string Query = "query";

        /// <summary>
        /// GraphQL mutation.
        /// </summary>
        public const string Mutation = "mutation";

        /// <summary>
        /// GraphQL subscription.
        /// </summary>
        public const string Subscription = "subscription";
    }
}