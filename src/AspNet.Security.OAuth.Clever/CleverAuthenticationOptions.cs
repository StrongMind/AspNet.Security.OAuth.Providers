﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using static AspNet.Security.OAuth.Clever.FitbitAuthenticationConstants;

namespace AspNet.Security.OAuth.Clever
{
    /// <summary>
    /// Defines a set of options used by <see cref="FitbitAuthenticationHandler"/>.
    /// </summary>
    public class FitbitAuthenticationOptions : OAuthOptions
    {
        public FitbitAuthenticationOptions()
        {
            ClaimsIssuer = CleverAuthenticationDefaults.Issuer;
            CallbackPath = CleverAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = CleverAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = CleverAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = CleverAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("profile");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.District, "district");
        }
    }
}
