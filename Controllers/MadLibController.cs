// Amardeep Mann
// 10-26-22
// Mad Lib - Endpoint
// Pull in variables via URL for our Mad Libs API project
// Peer reviewed by Jessie Lamzon: The use of switch worked well for this project and i like how you did it.  I did not run with errors and followed the assigment requirements.  Cool how you added the default switch too.  Good job!
// Testing URL: https://localhost:7201/madlib/Harman/sick/cop/Weezer/silly/strong/whistle/cans/thicc/sleeping

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
      words[0] = word0; // name
      words[1] = word1; // adj
      words[2] = word2; // occupation
      words[3] = word3; // band
      words[4] = word4; // adj
      words[5] = word5; // adj
      words[6] = word6; // noun
      words[7] = word7; // noun (plural)
      words[8] = word8; // noun
      words[9] = word9; // verb ending in -ing
      return $"Did you ever hear the tragedy of Darth {words[0]} the {words[1]}? I thought not. It\'s not a story a {words[2]} would tell you. It\'s a {words[3]} legend. Darth {words[0]} was a Dark Lord of {words[3]}, so {words[4]} and so {words[5]} he could use the {words[6]} to influence midichlorians to create {words[7]}. He had such a knowledge of the {words[8]} side of The Force that he could even keep the ones he cared about from {words[9]}.";
    }
}
