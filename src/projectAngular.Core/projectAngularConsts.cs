using projectAngular.Debugging;

namespace projectAngular
{
    public class projectAngularConsts
    {
        public const string LocalizationSourceName = "projectAngular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "dfdee52e2a06475aad7a70ae75ed365c";
    }
}
