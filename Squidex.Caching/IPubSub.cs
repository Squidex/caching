﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Threading.Tasks;

namespace Squidex.Caching
{
    public interface IPubSub
    {
        Task PublishAsync(object? payload);

        Task SubscribeAsync(Action<object?> subscriber);
    }
}
