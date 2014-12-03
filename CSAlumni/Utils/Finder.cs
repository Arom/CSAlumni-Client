using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Utils {
    public static class Finder {

        public static User findUserById(int id, List<User> userList) {
            User FoundUser = null;
            foreach (User user in userList) {
                if (user.id == id) {
                    FoundUser = user;
                    break;
                }
            }
            return FoundUser;
        }
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

        public static Broadcast findBroadcastById(int id, List<Broadcast> broadcastList) {
            Broadcast foundBroadcast = null;
            foreach (Broadcast broadcast in broadcastList) {
                if (broadcast.id == id) {
                    foundBroadcast = broadcast;
                }
            }
            return foundBroadcast;
        }
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
