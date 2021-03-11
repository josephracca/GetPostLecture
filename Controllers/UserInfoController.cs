using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureWithAngel.Models;
using LectureWithAngel.service;
using LectureWithAngel.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LectureWithAngel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    //inheritance ---> controller base ()
    //required to have the routes when building out an API piece
    {

        //connect tot he service by calling it's name
        private readonly UserInfoService _datafromsql;
        //don't forget to cmmd+. to get the proper using statement

        //follow proper naming conventions
        //now we are able to connect to the service and data
        public UserInfoController(UserInfoService data)
        {
            _datafromsql = data;
        }
        //we need to add something, it's currently missing

        [HttpGet]
        public IEnumerable<UserInfoModel> GetUserInfo()
        //if we ahve anything on the left side of the function, we need to give it a return value
        {
            return _datafromsql.GetUsersInfo();
            //this is a new function/method ^^^
            //we'll be creating this in the service
        }


        //copied above method and pasted below to create a new function
        //
        [HttpPost("add")]
        //("add") <----- this is going to elt us write to our database, will specify route that we need to target to post, ELSE it would return a '405'
        //will show it translates in Postman
        // int postman /add to the end of the URL for the API request
        public bool AddUserInfo(UserInfoModel User)
        //we are going to return a boolean
        //take a step back; when we pass data to a function, we need to pass type and variable
        {
            return _datafromsql.AddUsersInfo(User);
            //then now we need to give it some info to add


        }
    }
}

// we need to make our data service, just understand the basics of construction
// jumping back in after the UserInfoService.cs
// what to do first... we can connect to the service or create skeleton of the get function