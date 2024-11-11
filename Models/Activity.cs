namespace DATAGOV_API_INTRO_8.Models
{
   

    

    public class Activity
    {
        public string categoryid { get; set; }
        public string category { get; set; }
        public string eventid { get; set; }
        public string date { get; set; }
        public string datestart { get; set; }
        public string dateend { get; set; }
        public string recurrencedatestart { get; set; }
        public string recurrencedateend { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string isrecurring { get; set; }
        public string isallday { get; set; }
        public string isregresrequired { get; set; }
        public string isfree { get; set; }
        public string regresurl { get; set; }
        public string regresinfo { get; set; }
        public string infourl { get; set; }
        public string feeinfo { get; set; }
        public string timeinfo { get; set; }
        public string title { get; set; }
        public string contactname { get; set; }
        public string contacttelephonenumber { get; set; }
        public string contactemailaddress { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string[] tags { get; set; }
        public string[] types { get; set; }
        public string recurrencerule { get; set; }
        public string sitecode { get; set; }
        public string sitetype { get; set; }
        public DateTime datetimecreated { get; set; }
        public DateTime? datetimeupdated { get; set; }
        public string createuser { get; set; }
        public string updateuser { get; set; }
        public object risdpoiid { get; set; }
        public string[] dates { get; set; }
        public object[] images { get; set; }
        public string imageidlist { get; set; }
        public string subjectname { get; set; }
        public string parkfullname { get; set; }
        public string portalname { get; set; }
        public string organizationname { get; set; }
        public string id { get; set; }
    }

    

    public class Activities
    {
        public List<Activity> data { get; set; }
    }
}
