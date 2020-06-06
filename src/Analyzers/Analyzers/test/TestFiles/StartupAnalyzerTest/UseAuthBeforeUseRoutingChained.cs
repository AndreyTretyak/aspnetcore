// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;

namespace Microsoft.AspNetCore.Analyzers.TestFiles.StartupAnalyzerTest {
    public class UseAuthBeforeUseRoutingChained
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseFileServer()
               .UseAuthorization()
               .UseRouting()
               .UseEndpoints(r => { });
        }
    }
}