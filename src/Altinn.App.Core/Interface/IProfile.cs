using Altinn.Platform.Profile.Models;

namespace Altinn.App.Core.Interface
{
    /// <summary>
    /// Interface for profile functionality
    /// </summary>
    public interface IProfile
    {
        /// <summary>
        /// Method for getting the userprofile from a given user id
        /// </summary>
        /// <param name="userId">the user id</param>
        /// <returns>The userprofile for the given user id</returns>
        Task<UserProfile> GetUserProfile(int userId);
    }
}
