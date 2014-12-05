using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Utils {
    /// <summary>
    /// This class is used to find Users and Broadcasts by various variables.
    /// </summary>
    public static class Finder {
        /// <summary>
        /// Find User by its ID.
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="userList">List of Users (Preferably up-to-date)</param>
        /// <returns>A user if found. </returns>
        public static User findUserById(int id, List<User> userList) {
            User FoundUser = null;
            foreach (User user in userList) {
                if (user.Id == id) {
                    FoundUser = user;
                    break;
                }
            }
            return FoundUser;
        }
        /// <summary>
        /// Find User by its email address.
        /// </summary>
        /// <param name="email">User email.</param>
        /// <param name="userList">List of Users (Preferably up-to-date)</param>
        /// <returns>A user if found. </returns>
        public static User findUserByEmail(string email, List<User> userList) {
            User FoundUser = null;
            foreach (User user in userList) {
                if (user.Email.Equals(email)) {
                    FoundUser = user;
                    break;
                }
            }
            return FoundUser;
        }
        /// <summary>
        /// Find User by its surname.
        /// </summary>
        /// <param name="surname">User Surname.</param>
        /// <param name="userList">List of Users (Preferably up-to-date)</param>
        /// <returns>A user if found. </returns>
        public static User findUserBySurname(string surname, List<User> userList) {
            User FoundUser = null;
            foreach (User user in userList) {
                if (user.Surname.Equals(surname)) {
                    FoundUser = user;
                    break;
                }
            }
            return FoundUser;
        }
        /// <summary>
        /// Find Broadcast by its ID.
        /// </summary>
        /// <param name="id">Broadcast id.</param>
        /// <param name="broadcastList">List of Broadcasts (Preferably up-to-date)</param>
        /// <returns>A broadcast if found.</returns>
        public static Broadcast findBroadcastById(int id, List<Broadcast> broadcastList) {
            Broadcast foundBroadcast = null;
            foreach (Broadcast broadcast in broadcastList) {
                if (broadcast.id == id) {
                    foundBroadcast = broadcast;
                }
            }
            return foundBroadcast;
        }
        /// <summary>
        /// Find Broadcast by its content.
        /// </summary>
        /// <param name="content">Broadcast content.</param>
        /// <param name="broadcastList">List of Broadcasts (Preferably up-to-date)</param>
        /// <returns>A broadcast if found.</returns>
        public static Broadcast findBroadcastByContent(string content, List<Broadcast> broadcastList) {
            Broadcast foundBroadcast = null;
            foreach (Broadcast broadcast in broadcastList) {
                if (broadcast.content.Equals(content)) {
                    foundBroadcast = broadcast;
                    break;
                }
            }
            return foundBroadcast;
        }
    }
}
