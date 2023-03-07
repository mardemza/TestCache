using TestCache.Debugging;

namespace TestCache
{
    public class TestCacheConsts
    {
        public const string LocalizationSourceName = "TestCache";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "29234ccbc8124e829691c4ccf2c4f2fa";
    }
}
