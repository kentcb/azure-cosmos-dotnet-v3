﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.Common
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Cosmos.Internal;

    internal interface IRequestSigner
    {
        Task SignRequestAsync(DocumentServiceRequest request, CancellationToken cancellationToken);
    }
}
