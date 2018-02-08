using System.Collections.Generic;

namespace HealthCare
{
    public class HealthCareConsts
    {
        public const string LocalizationSourceName = "HealthCare";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;
    }

    public class UserProfile {

        public UserProfile() {
            UserProfileHistories = new HashSet<UserProfileHistory>();
        }

        public string Description { get; set; }

        public virtual ICollection<UserProfileHistory> UserProfileHistories { get; set; }
    }

    public class UserProfileHistory {
        public string Name { get; set; }

        public string Comment { get; set; }

        public long UserProfileId { get; set; }

        public virtual UserProfile UserProfile { get; set; }


    }
}
