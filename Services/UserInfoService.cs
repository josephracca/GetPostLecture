using System.Collections.Generic;
using LectureWithAngel.Models;

namespace LectureWithAngel.Services
{
    public class UserInfoService
    {
        public UserInfoService()
        {
            //we are going to make what's called "Fixed Data": a ghard-coded list as our database for the time-being
            //how to create a list in c#



        }
//we are making a list of type UserInfoModel, which needs to match one for one...
        public List<UserInfoModel> fixedData = new List<UserInfoModel>{
            new UserInfoModel
            {
                //object must contain every single property inside the model
                Id = 1,
                UserName = "Joseph",
                Password = "password"
                //much like TypeScript
            },
            new UserInfoModel
            {
                Id = 2,
                UserName = "Golden",
                Password = "password"
            },
            new UserInfoModel
            {
                Id = 3,
                UserName = "Bruno",
                Password = "password"
            }
        };

        public IEnumerable<UserInfoModel> GetUsersInfo(){
            return fixedData;
        }

        public bool AddUsersInfo(UserInfoModel User){
            //mirrors the function/method call in the controller

            fixedData.Add(User);
            return true;

            //challenge: figure out a way to make a check to see if our user already exists.. return true or false based on that logic...
        }
    }
}

//so in Postman (example at end of lecture)
//when we were signing in to our login, we signed in passing over an object, but in postman
// click on body -> raw -> type in the data exactly like the model