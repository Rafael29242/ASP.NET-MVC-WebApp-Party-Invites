using System.Collections.Generic;

namespace PartyInvites.Models
{
    public class Repository
    {

        //Fields & Properties

        private static List<GuestResponse> responses = new List<GuestResponse>();

        //Constructors

        //Methods

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public static List<GuestResponse> GetResponses()
        {
            return responses;
        }

    }
}
