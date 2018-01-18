﻿// Copyright (c) Lykke Corp.
// See the LICENSE file in the project root for more information.

namespace IdentityServer4.Quickstart.UI
{
    public static class ConsentOptions
    {
        public static readonly bool EnableOfflineAccess = true;
        public static readonly string OfflineAccessDisplayName = "Offline Access";
        public static readonly string OfflineAccessDescription = "Access to your applications and resources, even when you are offline";

        public static readonly string MustChooseOneErrorMessage = "You must pick at least one permission";
        public static readonly string InvalidSelectionErrorMessage = "Invalid selection";
    }
}
