using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAlumni;
using CSAlumni.Models;
using NUnit.Framework;

using CSAlumni.Utils;
namespace CSAlumniTest {
    [TestFixture]
    class TestRequests {
        string url = "http://178.62.230.34/";
        string password = "taliesin";
        string username = "admin";
        int responseCode = 0;
        SendDeleteRequest sendDelete;
        SendPostRequest sendPost;
        SendPatchRequest sendPatch;
        SendGetRequest sendGet;

        public TestRequests() {
            setVariables();
        }
        public void setVariables() {
            sendDelete = new SendDeleteRequest(username, password, url);
            sendPost = new SendPostRequest(username, password, url);
            sendGet = new SendGetRequest(username, password, url);
            sendPatch = new SendPatchRequest(username, password, url);
        }
        [Test]
        public void testAddUser() { 
            User user = new User("Chris", "Ilkow", "0999", 2012, true, "example@example.ex", 0);
            responseCode = sendPost.addNew(user);
            Assert.AreEqual(201, responseCode);
        }
        [Test]
        public void testPatchUser() {
            List<User> userList = sendGet.getUserList();
            User userToPatch = Finder.findUserByEmail(userList[0].Email, userList);
            userToPatch.Firstname = "ChrisPatched";
            responseCode = sendPatch.patchUser(userToPatch);
            Assert.AreEqual(204, responseCode);
        }
 
        [Test]
        public void testRemoveUser() {
           List<User> userList = sendGet.getUserList();
            User userToDelete = Finder.findUserByEmail(userList[0].Email, userList);
            if (userToDelete != null)
            {
                if (userToDelete.Id != 41)
                {
                    responseCode = sendDelete.delete("users", userToDelete.Id);
                    Assert.AreEqual(204, responseCode);
                }
               
            }
        }
       [Test]
        public void testAddBroadcast() {

            Feeds feed = new Feeds(0, 0, 0, 0, 1, "cs-alumni");
            BroadcastToSend broadcast = new BroadcastToSend("TestContent", feed);
            responseCode= sendPost.addNew(broadcast);
            Assert.AreEqual(201, responseCode);
        }
        [Test]
        public void testRemoveBroadcast() {
            List<Broadcast> broadcastList = sendGet.getBroadcastList();
            Broadcast broadcastToDelete = Finder.findBroadcastByContent(broadcastList[0].Content, broadcastList);
            if (broadcastToDelete != null)
            {
            responseCode = sendDelete.delete("broadcasts", broadcastToDelete.id);
            Assert.AreEqual(204, responseCode);
            }
        }
        [Test]
        public void testLoginIsValid() {
          SendGetRequest sendLogin = new SendGetRequest(username, password, url);
          int response = sendGet.LoginIsValid();
          Assert.AreEqual(200, response);
        }
      
    }
}
