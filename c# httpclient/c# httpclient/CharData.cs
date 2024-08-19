using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace c__httpclient
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public List<string> Episode { get; set; }
    }

    public class CharacterListResponse
    {
        public List<Character> Results { get; set; }
    }
}
