using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PesqProg.Models
{
    public class Repository
    {
        public static List<ProgResponse> responses = new List<ProgResponse>();

        public static IEnumerable<ProgResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(ProgResponse progResponse)
        {
            responses.Add(progResponse);
        }
    }
}
