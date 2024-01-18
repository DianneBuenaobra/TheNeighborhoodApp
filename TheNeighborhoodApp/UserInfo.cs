using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNeighborhoodApp
{
    public class UserInfo
    {
        private string firstname, lastname, Street, gender, Username, Password, UserType, phonenumber, verified;
        private int Age, Homenumber;
        
       

        public void setFirstname(string value) {    firstname = value; }
        public string getFirstname() { return firstname; }

        public string getLastname() { return lastname;}

        public void setLastname(string value) { lastname = value; }
        public string getStreet() { return Street; }

        public void setStreet(string value) { Street = value; } 
        public string getGender() { return gender; }

        public void setGender(string value) { gender = value; }
        public string getUsername() { return Username; }
        public void setUsername(string value) { Username = value; }
        public string getPassword() { return Password; }

        public void setPassword(string value) { Password = value; }
        public string getUserType() { return UserType; }

        public void setUserType(string value) { UserType = value; }
        public string getPhonenumber() {  return phonenumber; }

        public void setPhonenumber(string value) {  phonenumber = value; }
        public string getVerified() { return verified;}

        public void setVerified(string value) { verified = value; }
        public void setAge(int value) { Age = value; }
        public int getAge() { return Age; }
        public int getHomenumber() { return Homenumber;}
        public void setHomenumber(int value) { Homenumber = value; }

        public Image image { get; set; }
      
       
     
       
        
       
    }
}
