using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace techceler.Controllers
{
    public class WebController : ApiController
    {

        private static List<string> timeList = new List<string> { "UTC +14	Samoa and Christmas Island/Kiribati", "UTC +13:45	Chatham Islands/New Zealand", "UTC +13	New Zealand with exceptions and 4 more", "UTC +12	Fiji, small region of Russia and 6 more", "UTC +11	much of Australia and 8 more", "UTC +10:30	small region of Australia", "UTC +10	Queensland/Australia and 6 more", "UTC +9:30	Northern Territory/Australia", "UTC +9	Japan, South Korea and 4 more", "UTC +8:45	Western Australia/Australia", "UTC +8:30	North Korea", "UTC +8	China, Philippines and 10 more", "UTC +7	much of Indonesia, Thailand and 7 more", "UTC +6:30	Myanmar and Cocos Islands", "UTC +6	Bangladesh and 6 more", "UTC +5:45	Nepal", "UTC +5:30	India and Sri Lanka", "UTC +5	Pakistan and 8 more", "UTC +4:30	Afghanistan", "UTC +4	Azerbaijan and 8 more", "UTC +3:30	Iran", "UTC +3	Moscow/Russia and 22 more", "UTC +2	Greece and 31 more", "UTC +1	Germany and 44 more", "UTC +0	United Kingdom and 25 more", "UTC -1	Cabo Verde and 2 more", "UTC -2	regions of Brazil and South Georgia/Sandwich Is.", "UTC -3	Argentina, regions of Brazil and 9 more", "UTC -3:30	Newfoundland and Labrador/Canada", "UTC -4	some regions of Canada and 29 more", "UTC -5	regions of USA and 13 more", "UTC -6	regions of USA and 9 more", "UTC -7	some regions of USA and 2 more", "UTC -8	regions of USA and 4 more", "UTC -9	Alaska/USA and regions of French Polynesia", "UTC -9:30	Marquesas Islands/French Polynesia", "UTC -10	small region of USA and 2 more", "UTC -11	American Samoa and 2 more", "UTC -12	much of US Minor Outlying Islands"};

       // TimeZoneInfo timeInfo = TimeZoneInfo.FindSystemTimeZoneById(GetFromConfig.ManilaTimeZoneKey());
        
        

// ManilaTime = TimeZoneInfo.ConvertTime(dateTime.Value, TimeZoneInfo.Local, timeInfo).ToUniversalTime();
        public IEnumerable<string> GetTime()
        {
            return timeList;
        }
        
        public string GetTimeById(int id)
        {
            return timeList[id];
        }
    }
}
