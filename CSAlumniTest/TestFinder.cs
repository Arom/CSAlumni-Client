using CSAlumni;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAlumni.Utils;
using CSAlumni.Models;

namespace CSAlumniTest {
    [TestFixture]
    class TestFinder {

        string username = "admin";
        string password = "taliesin";
        string url = "http://178.62.230.34/";
        SendGetRequest sendGet;
        SendPostRequest sendPost;
        SendDeleteRequest sendDelete;
        public TestFinder() {
            setVariables();
        }
        public void setVariables() {
            sendDelete = new SendDeleteRequest(username, password, url);
            sendPost = new SendPostRequest(username, password, url);
            sendGet = new SendGetRequest(username, password, url);
        }
        [Test]
        public void testFindBroadcastByContent() {
            List<Broadcast> broadcastList = sendGet.getBroadcastList();
            Broadcast foundBroadcast = Finder.findBroadcastByContent(broadcastList[0].Content, broadcastList);
            if (foundBroadcast != null) {
                Assert.AreEqual(broadcastList[0].Content, foundBroadcast.Content);
            }        
        }
        [Test]
        public void testFindUserByEmail() {
            List<User> userList = sendGet.getUserList();
            User foundUser = Finder.findUserByEmail(userList[0].Email, userList);
            if (foundUser!=null) {
                Assert.AreEqual(userList[0].Email, foundUser.Email);
            }
        }
        [Test]
        public void testFindUserById()
        {
            List<User> userList = sendGet.getUserList();
            User testUser = Finder.findUserByEmail("cwl9@aber.ac.uk", userList);
            User foundUser = Finder.findUserById(testUser.Id, userList);
            if (foundUser != null)
            {
                Assert.AreEqual(testUser.Id, foundUser.Id);
            }
        }
        [Test]
        public void testFindUserBySurname() 
        {
            List<User> userList = sendGet.getUserList();
            User foundUser = Finder.findUserBySurname(userList[0].Surname, userList);
            if (foundUser != null) {
                Assert.AreEqual(userList[0].Surname, foundUser.Surname);
            } 
        }
        [Test]
        public void testFindUserByGradYear()
        {
            List<User> userList = sendGet.getUserList();
            User foundUser = Finder.findUserByGradYear(userList[0].Grad_year, userList);
            
            if (foundUser != null) {
                Assert.AreEqual(userList[0].Grad_year,foundUser.Grad_year);
            }
        }
        [Test]
        public void testFindUserByPhone() {
            List<User> userList = sendGet.getUserList();
            User foundUser = Finder.findUserByPhone(userList[0].Phone, userList);
            if (foundUser != null) {
                Assert.AreEqual(userList[0].Phone, foundUser.Phone);
            }
        }
        [Test]
        public void findUserByFirstname() {
            List<User> userList = sendGet.getUserList();
            User foundUser = Finder.findUserByFirstname(userList[0].Firstname, userList);
            if (foundUser != null) {
                Assert.AreEqual(userList[0].Firstname, foundUser.Firstname);
            }
        }

    }
}
