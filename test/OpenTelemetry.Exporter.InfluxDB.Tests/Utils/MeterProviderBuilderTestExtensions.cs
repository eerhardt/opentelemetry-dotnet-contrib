// <copyright file="MeterProviderBuilderTestExtensions.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;

namespace OpenTelemetry.Exporter.InfluxDB.Tests.Utils;

public static class MeterProviderBuilderTestExtensions
{
    public static MeterProviderBuilder ConfigureDefaultTestResource(this MeterProviderBuilder meterProviderBuilder)
    {
        return meterProviderBuilder.ConfigureResource(builder => builder.AddService(
            serviceName: "my-service",
            serviceNamespace: "my-service-namespace",
            serviceVersion: "1.0",
            serviceInstanceId: "my-service-id"));
    }
}
