// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Immutable;

namespace Pulumiverse.Unifi
{
    public static class Config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "IDE1006", Justification = 
        "Double underscore prefix used to avoid conflicts with variable names.")]
        private sealed class __Value<T>
        {
            private readonly Func<T> _getter;
            private T _value = default!;
            private bool _set;

            public __Value(Func<T> getter)
            {
                _getter = getter;
            }

            public T Get() => _set ? _value : _getter();

            public void Set(T value)
            {
                _value = value;
                _set = true;
            }
        }

        private static readonly Pulumi.Config __config = new Pulumi.Config("unifi");

        private static readonly __Value<bool?> _allowInsecure = new __Value<bool?>(() => __config.GetBoolean("allowInsecure") ?? Utilities.GetEnvBoolean("UNIFI_INSECURE"));
        /// <summary>
        /// Skip verification of TLS certificates of API requests. You may need to set this to `true` if you are using your local
        /// API without setting up a signed certificate. Can be specified with the `UNIFI_INSECURE` environment variable.
        /// </summary>
        public static bool? AllowInsecure
        {
            get => _allowInsecure.Get();
            set => _allowInsecure.Set(value);
        }

        private static readonly __Value<string?> _apiUrl = new __Value<string?>(() => __config.Get("apiUrl") ?? Utilities.GetEnv("UNIFI_API"));
        /// <summary>
        /// URL of the controller API. Can be specified with the `UNIFI_API` environment variable. You should **NOT** supply the
        /// path (`/api`), the SDK will discover the appropriate paths. This is to support UDM Pro style API paths as well as more
        /// standard controller paths.
        /// </summary>
        public static string? ApiUrl
        {
            get => _apiUrl.Get();
            set => _apiUrl.Set(value);
        }

        private static readonly __Value<string?> _password = new __Value<string?>(() => __config.Get("password") ?? Utilities.GetEnv("UNIFI_PASSWORD"));
        /// <summary>
        /// Password for the user accessing the API. Can be specified with the `UNIFI_PASSWORD` environment variable.
        /// </summary>
        public static string? Password
        {
            get => _password.Get();
            set => _password.Set(value);
        }

        private static readonly __Value<string?> _site = new __Value<string?>(() => __config.Get("site") ?? Utilities.GetEnv("UNIFI_SITE"));
        /// <summary>
        /// The site in the Unifi controller this provider will manage. Can be specified with the `UNIFI_SITE` environment variable.
        /// Default: `default`
        /// </summary>
        public static string? Site
        {
            get => _site.Get();
            set => _site.Set(value);
        }

        private static readonly __Value<string?> _username = new __Value<string?>(() => __config.Get("username") ?? Utilities.GetEnv("UNIFI_USERNAME"));
        /// <summary>
        /// Local user name for the Unifi controller API. Can be specified with the `UNIFI_USERNAME` environment variable.
        /// </summary>
        public static string? Username
        {
            get => _username.Get();
            set => _username.Set(value);
        }

    }
}
