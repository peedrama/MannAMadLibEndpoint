// Amardeep Mann
// 10-26-22
// Mad Lib - Endpoint
// Pull in variables via URL for our Mad Libs API project
// Peer reviewed by 

using Microsoft.AspNetCore.Mvc;

namespace MannAMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]

    public string MadLibDefault()
    {
      string[] words = new string[10];
      words[0] = "Jimmy G";
      words[1] = "dreadful";
      words[2] = "lint licker";
      words[3] = "The Partridge Family";
      words[4] = "stupid";
      words[5] = "deceptively handsome";
      words[6] = "power of love";
      words[7] = "mushrooms";
      words[8] = "warm and fuzzy";
      words[9] = "coming to his surprise birthday party";
      return $"Did you ever hear the tragedy of Darth {words[0]} the {words[1]}? I thought not. It\'s not a story a {words[2]} would tell you. It\'s a {words[3]} legend. Darth {words[0]} was a Dark Lord of {words[3]}, so {words[4]} and so {words[5]} he could use the {words[6]} to influence midichlorians to create {words[7]}. He had such a knowledge of the {words[8]} side of The Force that he could even keep the ones he cared about from {words[9]}.";
    }

    [HttpGet]
    [Route("{word0}/{word1}/{word2}/{word3}/{word4}/{word5}/{word6}/{word7}/{word8}/{word9}")]

    public string MadLib(string word0, string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9)
    {
      string[] words = new string[10];
      words[0] = word0;
      words[1] = word1;
      words[2] = word2;
      words[3] = word3;
      words[4] = word4;
      words[5] = word5;
      words[6] = word6;
      words[7] = word7;
      words[8] = word8;
      words[9] = word9;
      return $"Did you ever hear the tragedy of Darth {words[0]} the {words[1]}? I thought not. It\'s not a story a {words[2]} would tell you. It\'s a {words[3]} legend. Darth {words[0]} was a Dark Lord of {words[3]}, so {words[4]} and so {words[5]} he could use the {words[6]} to influence midichlorians to create {words[7]}. He had such a knowledge of the {words[8]} side of The Force that he could even keep the ones he cared about from {words[9]}.";
    }
}
