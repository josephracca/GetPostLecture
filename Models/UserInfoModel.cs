namespace LectureWithAngel.Models
{
    public class UserInfoModel
    {
        
        //create properties
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //always make a constructor
        public UserInfoModel(){}

        //now we're going to setup our controller

    }
}